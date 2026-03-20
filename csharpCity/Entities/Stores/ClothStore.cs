using csharpCity.Entities.Products;

namespace csharpCity.Entities;

public class ClothStore : Store<ClothProduct>
{
    public ClothStore(int id, string name) : base(id, name)
    {
        Fee = 4;
    }
}