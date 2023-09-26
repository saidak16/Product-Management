using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class Expensess
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public DateTime DateOfExpense { get; set; }
        public double Amount { get; set; }
    }
}
