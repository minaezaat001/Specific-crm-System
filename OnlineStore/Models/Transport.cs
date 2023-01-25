using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Transport
    {
        [Key]
        public int TransId  { get; set; }
        public string Country { get; set; }
        public decimal Cost { get; set; }

    }
}
