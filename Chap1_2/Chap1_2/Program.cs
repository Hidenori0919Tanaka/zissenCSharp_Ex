using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass { X = 1, Y = 2 };

            MyStruct myStruct = new MyStruct { X = 1, Y = 2 };

            new PrintObjectsClas().PrintObjects(myClass, myStruct);

            new PrintObjectsClas().PrintObjects(new MyClass { X = 0, Y = 0 }, new MyStruct { X = 2, Y = 2 });
        }
    }
}
