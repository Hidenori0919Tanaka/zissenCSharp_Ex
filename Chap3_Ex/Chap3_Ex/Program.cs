using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var exists = number.Exists(e => 8 % e == 0 || 9 % e == 0);
            foreach (var n in number)
            {
                Console.WriteLine((n / 2.0).ToString());
            }

            foreach (var n in number.Where(w => w >= 50))
            {
                Console.WriteLine(n);
            }

            foreach (var n in number.Select(s => s * 2))
            {
                Console.WriteLine(n);
            }

            var names = new List<string>
            {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Camberra", "Hong Kong",
            };
            var inputCity = Console.ReadLine();
            for (int count = 0; count < inputCity.Length; count++)
            {
                var judge = names.FindIndex(f => f == inputCity.Substring(count));
                if (judge >= 0)
                {

                }
                else
                {
                    break;
                }
            }
            var wordCount = names.Count(c => c == "o");

            foreach (var n in names.Where(w => w == "o"))
            {

            }

            foreach (var n in names.Where(w => w == "B").Select(s => s.Count()))
            {

            }
        }
    }
}
