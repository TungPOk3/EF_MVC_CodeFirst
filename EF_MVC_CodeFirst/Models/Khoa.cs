﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC_CodeFirst.Models
{
    public class Khoa
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public ICollection<Lop> Lops { get; set; }
    }
}
