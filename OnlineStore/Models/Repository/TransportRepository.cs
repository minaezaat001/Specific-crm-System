using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class TransportRepository :IStore<Transport>
    {
        private readonly AppDbContext dp;

        public TransportRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(Transport entity)
        {
            dp.Transports.Add(entity);
            dp.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = Find(id);
            dp.Transports.Remove(product);
            dp.SaveChanges();
        }

        public Transport Find(int id)
        {
            var transport = dp.Transports.Find(id);
            return transport;
        }

        public IList<Transport> List()
        {
            return dp.Transports.ToList();
        }

        public void Update(int id, Transport entity)
        {
            var cust = Find(id);
            dp.Transports.Update(cust);
            dp.SaveChanges();

        }
    }
}
