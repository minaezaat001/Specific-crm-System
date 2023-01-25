using OnlineStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
    public class UserRepository : IStore<User>
    {
        private readonly AppDbContext dp;

        public UserRepository(AppDbContext dp)
        {
            this.dp = dp;
        }
        public void Add(User entity)
        {
            dp.Users.Add(entity);
            commit();
        }

        public void Delete(int id)
        {
            var user =Find(id);
            dp.Users.Remove(user);
            commit();
        }

        public User Find(int id)
        {
            var user = dp.Users.Find(id);
            return user;
        }

        public IList<User> List()
        {
            return dp.Users.ToList();
        }

        public void Update(int id, User entity)
        {
            var user = Find(id);
            dp.Users.Update(user);
            commit();
        }
        public void commit() { dp.SaveChanges(); }
    }
}
