using System.Collections.Generic;
using bookpage.business.Abstract;
using bookpage.data.Abstract;
using bookpage.entity;

namespace bookpage.business.Concrate
{
    public class ProductManager : IProductServices
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productrepository)
        {
            _productRepository=productrepository;
        }
        public void Create(Product Entity)
        {
            _productRepository.Create(Entity);
        }

        public void Delete(Product Entity)
        {
            _productRepository.Delete(Entity);
        }

        public List<Product> GetAll()
        {
           return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
          return _productRepository.GetById(id);

        }

        public Product GetProductDetails(string name)
        {
            return _productRepository.GetProductDetails(name);
        }

         public Product GetProductpageDetails(int id)
         {
            return _productRepository.GetProductpageDetails(id); //şimdi burdaki metoduda webui'da kullanıcaz
         }

        public List<Product> GetProductsByCategory(string name)
        {
            return _productRepository.GetProductsByCategory(name);
        }

        public void Update(Product Entity)
        {
            _productRepository.Update(Entity);
        }
    }
}