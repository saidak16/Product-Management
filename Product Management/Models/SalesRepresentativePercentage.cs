using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class SalesRepresentativePercentage
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int SalesRepresentativeId { get; set; }
        public int Amount { get; set; }
        public DateTime DateOfInvoice { get; set; }
    }
}
