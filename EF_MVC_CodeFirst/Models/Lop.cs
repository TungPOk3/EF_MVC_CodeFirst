using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC_CodeFirst.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }
        public ICollection<Sinhvien> SinhViens { get; set; }
    }
}
