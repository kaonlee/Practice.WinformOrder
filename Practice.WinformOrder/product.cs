using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Winform
{
    public class Product
    {
        public string productCode { get; private set; }
        public string productName { get; private set; }
        public int price { get; private set; }
        public string productDescription { get; set; }

        public Product(string pName, int pPrice, string pDescrip = null)
        {
			Guid guid = Guid.NewGuid();
			this.productCode = guid.ToString();
            this.productName = pName;
            this.price = pPrice;
			this.productDescription = pDescrip ?? null;
		}
    }

       
}
