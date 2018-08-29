using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1_1.Product
{
    public class ProductClass
    {
        public int Num { get; set; }

        public int Price { get; private set; }

        public double PriceWithTax {
            get { return Price * 1.08; }
        }

        public ProductClass()
        {
            Num = 98;
            Price = 210;
        }
    }
}
