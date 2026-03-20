using csharpCity.Entities;
using csharpCity.Entities.Products;

ElectronicProduct ep = new ElectronicProduct(1, "test", 10);
Store<ElectronicProduct> es1 = new ElectronicStore(1,"MediaMarkt");

es1.AddProduct(ep);
es1.ShowProductList();
