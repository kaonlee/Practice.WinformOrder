using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Winform
{
    public class DefaultGoods
    {
        public Product pdMilk;
        public Product pdCola;
        public Product pdCoffee;

        private void defaultValue()
        {
            pdMilk = new Product("milk", 109);
            pdCola = new Product("cola", 30);
            pdCoffee = new Product("coffee", 90);
        }

        public void getDefaultValue()
        {
            defaultValue();
        }

    }

}
