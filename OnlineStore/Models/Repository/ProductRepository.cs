using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class ProductRepository :IStore<Product>
    {
        private readonly AppDbContext dp;

        public ProductRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(Product entity)
        {
            dp.Products.Add(entity);
            dp.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = Find(id);
            dp.Products.Remove(product);
            dp.SaveChanges();
        }

        public Product Find(int id)
        {
            var product = dp.Products.Find(id);
            return product;
        }

        public IList<Product> List()
        {
            return dp.Products.ToList();
        }

        public void Update(int id, Product entity)
        {
            var cust = Find(id);
            dp.Products.Update(cust);
            dp.SaveChanges();

        }
    }
}
