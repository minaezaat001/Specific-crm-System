using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class CustomerRepository : IStore<Customer>
    {
        private readonly AppDbContext dp;

        public CustomerRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(Customer entity)
        {
            dp.Customers.Add(entity);
            Commit();
        }

        public void Delete(int id)
        {
            var cust = Find(id);
            dp.Customers.Remove(cust);
            Commit();
        }

        public Customer Find(int id)
        {
            var cust = dp.Customers.Find(id);
            return cust;
        }

        public IList<Customer> List()
        {
            return dp.Customers.ToList();
        }

        public void Update(int id, Customer entity)
        {
            var cust = Find(id);
            dp.Customers.Update(cust);
            Commit();

        }

        public void Commit() { dp.SaveChanges(); }
    }
}
