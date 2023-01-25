using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class LoginRepository : IStore<Login>
    {
        private readonly AppDbContext dp;

        public LoginRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(Login entity)
        {
            dp.Logins.Add(entity);
            dp.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Login Find(int id)
        {
            var login = dp.Logins.Find(id);
            return login;
        }

        public IList<Login> List()
        {
            return dp.Logins.ToList();
        }

        public void Update(int id, Login entity)
        {
            throw new NotImplementedException();
        }
    }
}
