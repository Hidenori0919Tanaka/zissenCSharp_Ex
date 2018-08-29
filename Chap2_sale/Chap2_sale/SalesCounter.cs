﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_sale
{
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        //public SalesCounter(List<Sale> sales)
        //{
        //    _sales = sales;
        //}

        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        public IDictionary<string,int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ShopName] += sale.Amount;
                }
                else
                {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }

        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();

            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
