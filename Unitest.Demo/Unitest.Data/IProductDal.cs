namespace Unitest.Data
{
    public interface IProductDal
    {
        Product Insert(Product product);
        Product Get(string productName);
    }
}