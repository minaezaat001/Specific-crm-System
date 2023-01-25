using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Repository
{
  public interface IStore <TEntity>
    {
        IList<TEntity> List(); //get all data 

        TEntity Find(int id); //search 
        void Add(TEntity entity); //add  
        void Delete(int id); //delete 

        void Update(int id,  TEntity entity); //Update 

        //int GetId(); //get max id to display in view

    }
}
