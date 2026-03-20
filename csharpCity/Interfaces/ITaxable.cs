using csharpCity.Entities;

namespace csharpCity;

public interface ITaxable<TProduct> where TProduct : Product
{
    public double CalculateTax(TProduct product);
}