using csharpCity.Entities.Products;

namespace csharpCity.Entities;

public class ElectronicStore : Store<ElectronicProduct>
{
    public ElectronicStore(int id, string name) : base(id, name)
    {
        Fee = 3;
    }
}