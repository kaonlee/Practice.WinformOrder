using Practice_Winform;

namespace Practice.WinformOrder.Test
{
    public class ProductTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testproduct預設值設定()
        {
            Product testProduct = new Product("iPhone14", 2000);
            Assert.AreEqual(null, testProduct.productDescription);
        }

        [Test]
        public void TestDefaultGoods()
        {
            var defaultGoods = new DefaultGoods();
            defaultGoods.getDefaultValue();
            Assert.AreEqual(109, defaultGoods.pdMilk.price);
        }
    }
}