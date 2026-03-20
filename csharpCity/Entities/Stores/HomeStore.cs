using csharpCity.Entities.Products;

namespace csharpCity.Entities;

public class HomeStore : Store<HomeProduct>
{
    public HomeStore(int id, string name) : base(id, name)
    {
        Fee = 10;
    }
}