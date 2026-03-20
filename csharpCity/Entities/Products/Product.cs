namespace csharpCity.Entities;

public abstract class Product(int id, string name, double price)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    protected double Price { get; } = price;
}