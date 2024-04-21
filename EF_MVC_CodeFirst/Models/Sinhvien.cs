using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC_CodeFirst.Models
{
    public class Sinhvien
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public int LopId { get; set; }
        public Lop Lop { get; set; }
    }
}
