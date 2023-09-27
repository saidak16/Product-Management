using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public  class FinancialPosition
    {
        public double TotalExp { get; set; }
        public double TotalSeals { get; set; }
        public double TotalPur { get; set; }
        public double TotalCustomerRemainingAmount { get; set; }
        public double TotalSuplierRemainingAmount { get; set; }
    }
}
