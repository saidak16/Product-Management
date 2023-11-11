using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public int Holidays { get; set; }
        public byte[] EmpImage { get; set; }
        public string Email { get; set; }
    }
}
