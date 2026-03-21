using csharpCity.Utils;

namespace csharpCity.Entities;

public abstract class Store<TProduct> : ITaxable<TProduct> where TProduct : Product
{
    public int Id { get; }
    public string Name { get; }
    private List<TProduct> ProductsList { get; } = new();
    public int Fee { get; protected set; }

    public Store(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddProduct(TProduct product)
    {
        ProductsList.Add(product);
    }

    public Result RemoveProduct(TProduct product)
    {
        if (ProductsList.Remove(product))
        {
            return Result.Success();
        }

        return Result.Failure(Errors.ProductNotFound);
    }

    public void ShowProductList()
    {
        foreach (TProduct product in ProductsList)
        {
            Console.WriteLine(product.ToString());
        }
    }
    
    public double CalculateTax(TProduct p)
    {
        return ((p.Price / 100) * Fee);
    }
}