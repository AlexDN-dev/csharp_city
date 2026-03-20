namespace csharpCity.Entities;

public abstract class Product(int id, string name, double price)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public double Price { get; } = price;

    public override string ToString()
    {
        return $"ID : {Id} || Nom : {Name} || Prix : {Price}";
    }
}