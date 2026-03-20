namespace csharpCity.Entities;

public abstract class Product(int id, string name, double price)
{
    public string Name { get; } = name;
    protected double Price { get; } = price;
}