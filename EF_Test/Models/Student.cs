using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public int Age { get; set; }
        public String? Email { get; set; }
        public String? Phone { get; set; }
        public int Grade { get; set; }
        public DateTime Birtdate { get; set; }
    }
}
