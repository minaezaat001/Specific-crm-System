using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Login
    {
        [Key]
        public int LogId { get; set; }
        public User  User { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
