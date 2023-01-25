using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Product
    {
        [Key] 
        public int ProdID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qut { get; set; }
        public Category  Category { get; set; }

    }
}
