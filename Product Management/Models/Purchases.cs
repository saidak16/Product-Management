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
		public int ProductId { get; set; }
		public DateTime DateOfPurchase { get; set; }
		public DateTime ExpirationDate { get; set; }
		public int QTY { get; set; }
		public int PurchasingPrice { get; set; }
		public int SellingPrice { get; set; }
		public long price { get; set; }
		public long PaidAmount { get; set; }
		public long RemainingAmount { get; set; }
		public int PaymentMethodId { get; set; }
		public string InvoiceNumber { get; set; }
		public int BatchNumber { get; set; }
	}
}
