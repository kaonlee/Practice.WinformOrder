using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Winform
{
	public class Order
	{
        public Product Product { get; private set; }
		public int Quantity { get; private set; }
		public int Price { get; private set; }
        public string Buyer { get; set; }
        public Order( Product product, int quentity,string buyer) 
		{
			this.Product = product;
			this.Quantity = quentity;
			this.Buyer = buyer;
			this.Price = product.price*Quantity;
		}
		/// <summary>
		/// 總計輸入的List<Order>中 各商品的總數量與商品的總價；
		/// </summary>
		/// <param name="orderList"></param>
		/// <returns></returns>
	}

	public static class OrdersTools
	{
		static public List<(string pName, int oQuantity, int oPrice)> GetOrderSummary (this List<Order> orderList) 
		{	
			List < (string, int, int) > summary = new List<(string, int, int) >();
			foreach (Order orderItem in orderList)
			{
				if (orderItem.Quantity == 0) continue;
				int index = summary.FindIndex(x => x.Item1 == orderItem.Product.productName);
				if (index != -1)
				{
					summary[index] = (summary[index].Item1, summary[index].Item2 + orderItem.Quantity , summary[index].Item3 + orderItem.Price);
				}
				else
				{
					summary.Add((orderItem.Product.productName, orderItem.Quantity, orderItem.Price));
				}
			}
			return summary;
		}

		static public int GetOrderTotalPrice     (this List<Order> orderList)
		{
			int totalPrice = 0;
			foreach (Order order in orderList)
			{
				totalPrice += order.Price;
			}
			return totalPrice;
		}

		public static List<(string buyer, string summary, int totalPrice)> GetOrderSummaryByBuyer(this List<Order> orderList)
		{
			List<(string buyer, string summary, int totalPrice)> summaryByBuyer = new List<(string buyer, string summary, int totalPrice)>();

			// Group orders by buyer
			var ordersByBuyer = orderList.GroupBy(o => o.Buyer);

			// Calculate summary for each buyer
			foreach (var buyerGroup in ordersByBuyer)
			{
				string buyerName = buyerGroup.Key;
				List<(string pName, int oQuantity, int oPrice)> summary = new List<(string pName, int oQuantity, int oPrice)>();
				int totalPrice = 0;
				// Calculate summary for each product purchased by this buyer
				foreach (var orderItem in buyerGroup)
				{
					if (orderItem.Quantity == 0) continue;
					int index = summary.FindIndex(x => x.pName == orderItem.Product.productName);
					if (index != -1)
					{
						summary[index] = (summary[index].pName, summary[index].oQuantity + orderItem.Quantity, summary[index].oPrice + orderItem.Price);
					}
					else
					{
						summary.Add((orderItem.Product.productName, orderItem.Quantity, orderItem.Price));
					}
					totalPrice += orderItem.Price;
				}

				// Build summary string for this buyer
				string summaryString = string.Join(Environment.NewLine, summary.Select(s => $"{s.pName}\t{s.oQuantity}\t{s.oPrice}"));

				// Add summary for this buyer to the list
				summaryByBuyer.Add((buyerName, summaryString, totalPrice));
			}

			return summaryByBuyer;
		}
	}
}
