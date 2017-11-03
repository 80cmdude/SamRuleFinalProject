using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Models
{
	public class Transaction : BaseItem
	{
		public DateTime Date { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public decimal PreviosBalance { get; set; }
		public decimal DetuctedAmount { get; set; }
		public decimal NewBalance { get; set; }

		public Transaction(string productName, decimal productPrice)
		{
			ProductName = productName;
			ProductPrice = productPrice;
		}
	}
}
