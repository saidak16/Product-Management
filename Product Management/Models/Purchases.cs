using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class Purchases
    {
		public int Id { get; set; }
		public int SupplierId { get; set; }
		public DateTime DateOfPurchase { get; set; }
		public long price { get; set; }
		public long PaidAmount { get; set; }
		public long RemainingAmount { get; set; }
		public int PaymentMethodId { get; set; }
		public int InvoiceNumber { get; set; }
	}
}
