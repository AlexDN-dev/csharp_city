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

    public void RemoveProduct(TProduct product)
    {
        if (ProductsList.Remove(product))
        {
            Console.WriteLine($"Le produit {product.Name} à bien été supprimé.");
            return;
        }

        Console.WriteLine("Ce produit n'existe pas !");
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