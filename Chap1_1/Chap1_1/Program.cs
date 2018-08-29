using Chap1_1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var price = new ProductClass().PriceWithTax;
            Console.WriteLine(price.ToString());
            Console.ReadKey();
        }
    }
}
