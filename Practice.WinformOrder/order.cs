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
		static public List<(string pName, int oQuantity, int oPrice)> GetOrderSummary(this List<Order> orderList)
		{
			var summary = orderList.Where(o => o.Quantity > 0)
				.GroupBy(o => o.Product.productName)
				.Select(g => (g.Key, g.Sum(o => o.Quantity), g.Sum(o => o.Price)))
				.ToList();
			return summary;
		}

		static public int GetOrderTotalPrice(this List<Order> orderList)
		{
			return orderList.Sum(o => o.Price);
		}

		public static List<(string buyer, string summary, int totalPrice)> GetOrderSummaryByBuyer(this List<Order> orderList)
		{
			var summaryByBuyer = orderList.Where(o => o.Quantity > 0)
				.GroupBy(o => o.Buyer)
				.Select(g => (
					buyer: g.Key,
					summary: g.GroupBy(o => o.Product.productName)
						.Select(s => $"{s.Key}*{s.Sum(o => o.Quantity)}\t${s.First().Product.price * s.Sum(o => o.Quantity)}\r\n")
						.ToList(),
					totalPrice: g.GroupBy(o => o.Product.productName)
						.Select(s => s.First().Product.price * s.Sum(o => o.Quantity))
						.Sum()
				))
				.ToList();

			return summaryByBuyer.Select(s => (s.buyer, string.Join(Environment.NewLine, s.summary), s.totalPrice)).ToList();
		}



	}
}
