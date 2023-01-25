using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class OrderRepository : IStore<Order>
    {
        private readonly AppDbContext dp;

        public OrderRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(Order entity)
        {
            dp.Orders.Add(entity);
            commit();
        }

        public void Delete(int id)
        {
            var cat = Find(id);
            dp.Orders.Remove(cat);
            commit();
        }

        public Order Find(int id)
        {
            var cat = dp.Orders.Find(id);
            return cat;
        }



        public IList<Order> List()
        {
            return dp.Orders.ToList();
        }

        public void Update(int id, Order entity)
        {

            dp.Orders.Update(entity);
            commit();
        }

        public void commit() { dp.SaveChanges(); }
    }
}
