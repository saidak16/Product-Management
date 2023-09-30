using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class PurchaseDetails
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int productId { get; set; }
        public int BatchNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public int QTY { get; set; }
        public int PurchasePrice { get; set; }
        public int SellingPrice { get; set; }
        public int TotalPrice { get; set; }
    }
}
