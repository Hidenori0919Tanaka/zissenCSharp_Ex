using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1_2
{
    class PrintObjectsClas
    {
        public void PrintObjects(MyClass myClass, MyStruct myStruct)
        {

            Console.WriteLine("class X:" + myClass.X.ToString() + "Y:" + myClass.Y.ToString());
            Console.WriteLine("struct X:" + myStruct.X.ToString() + "Y:" + myStruct.Y.ToString());
        }

        public void Print2Objects(MyClass myClass, MyStruct myStruct)
        {
            Console.WriteLine("class X:" + myClass.XDubou + "Y:" + myClass.YDouble);
            Console.WriteLine("struct X:" + myStruct.XDouble + "Y:" + myStruct.YDouble);
        }
    }
}
