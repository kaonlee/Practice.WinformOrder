using Practice_Winform;
using System.Windows.Forms;

namespace Practice.WinformOrder.UI
{
	public partial class Form1 : Form
	{
		private DefaultGoods defaultGoods;
		private List<Order> orderlist = new List<Order>();
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			defaultGoods = new DefaultGoods();
			defaultGoods.getDefaultValue();
		}

		private void numUPcola_ValueChanged(object sender, EventArgs e)
		{
			lbCola.Text = $"{(numUPcola.Value * defaultGoods.pdCola.price).ToString()} 元";
		}


		private void numUPmilk_ValueChanged(object sender, EventArgs e)
		{
			lbMilk.Text = $"{(numUPmilk.Value * defaultGoods.pdMilk.price).ToString()} 元";
		}

		private void numUPcoffee_ValueChanged(object sender, EventArgs e)
		{
			lbCoffee.Text = $"{(numUPcoffee.Value * defaultGoods.pdCoffee.price).ToString()} 元";
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			listView1.View = View.Details;
			var milkOrder = new Order(defaultGoods.pdMilk, (int)numUPmilk.Value,tbBuyer.Text);
			var colaOrder = new Order(defaultGoods.pdCola, (int)numUPcola.Value,tbBuyer.Text);
			var coffeeOrder = new Order(defaultGoods.pdCoffee, (int)numUPcoffee.Value, tbBuyer.Text);

			orderlist.Add(milkOrder);
			orderlist.Add(colaOrder);
			orderlist.Add(coffeeOrder);

			List<(string pName, int oQantity, int oPrice)> orderSummary = orderlist.GetOrderSummary();
			string result = string.Empty;

			foreach (var order in orderSummary)
			{
				result = result + order.ToString();
				ListViewItem item = new ListViewItem(order.pName);
				item.SubItems.Add(order.oQantity.ToString());
				item.SubItems.Add($"{order.oPrice.ToString()} 元");
				// 將項目添加到 ListViewItems 集合中
				ListViewItem[] items = new ListViewItem[] { item };
				listView1.Items.AddRange(items);
			}
			textBox1.Text = result;
			numUPmilk.Value = 0;
			numUPcola.Value = 0;
			numUPcoffee.Value = 0;
		}
	}
}