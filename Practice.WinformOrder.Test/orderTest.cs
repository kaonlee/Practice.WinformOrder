using Practice_Winform;

namespace Practice.WinformOrder.Test
{
    public class OrderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        private List<Order> CreateTestOrders()
        {
            Product p1 = new Product("p1", 1000);
            Product p2 = new Product("p2", 100);
            Order order1 = new Order(p1, 2,"tom");
            Order order2 = new Order(p2, 3, "tom");
            Order order3 = new Order(p1, 3, "son");
            List<Order> orderList = new List<Order> { order1, order2, order3 };
            return orderList;
        }

        [Test]
        public void TestOrder()
        {
            Order order1 = CreateTestOrders()[0];
            Order order2 = CreateTestOrders()[1];
            Assert.AreEqual(2000, order1.Price);
            Assert.AreEqual(300, order2.Price);
        }

        [Test]
        public void TestOrderTools()
        {
            List<Order> orderList = CreateTestOrders();
            var orderSummary = orderList.GetOrderSummary();
            var p1Summary = orderSummary.FirstOrDefault(x => x.pName == "p1");

            Assert.IsNotNull(p1Summary);
            Assert.AreEqual(5, p1Summary.oQuantity);
            Assert.AreEqual(5000, p1Summary.oPrice);

            var ordertotalPrice = orderList.GetOrderTotalPrice();

            Assert.AreEqual(5300, ordertotalPrice);
        }



    }
}