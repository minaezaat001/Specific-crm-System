﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Description { get; set; }
       
    }
}
