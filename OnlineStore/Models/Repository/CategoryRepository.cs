using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class CategoryRepository : IStore<Category>
    {
        private readonly AppDbContext dp;

        public CategoryRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(Category entity)
        {
            dp.Categories.Add(entity);
            commit();
        }

        public void Delete(int id)
        {
            var cat = Find(id);
            dp.Categories.Remove(cat);
            commit();
        }

        public Category Find(int id)
        {
            var cat = dp.Categories.Find(id);
            return cat;
        }

       

        public IList<Category> List()
        {
            return dp.Categories.ToList();
        }

        public void Update(int id, Category entity)
        {
            
            dp.Update(entity);
            commit();
        }

         public  void commit() { dp.SaveChanges(); }
    }
}
