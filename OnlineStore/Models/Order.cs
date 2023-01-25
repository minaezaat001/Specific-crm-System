using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } // 
        public Customer Customer { get; set; }  
        public Product  Product { get; set; } // 
        public Transport Transport { get; set; } // 
        public User User { get; set; }    // 
        public string Size { get; set; } // 
        public string Note { get; set; } // 
        public decimal Total { get; set; } // 
        public DateTime OrderDate { get; set; } // 
        public string Comfirm { get; set; }    // 

    }
}
