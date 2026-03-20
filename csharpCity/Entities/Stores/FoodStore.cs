using csharpCity.Entities.Products;

namespace csharpCity.Entities;

public class FoodStore : Store<FoodProduct>
{
    public FoodStore(int id, string name) : base(id, name)
    {
        Fee = 9;
    }
}