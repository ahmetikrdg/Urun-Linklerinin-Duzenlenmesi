using System.Collections.Generic;
using bookpage.entity;

namespace bookpage.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetProductpageDetails(int id);
        List<Product> GetProductsByCategory(string name);
        Product GetProductDetails(string url);
        List<Product> GetPopularProducts();
    }
}