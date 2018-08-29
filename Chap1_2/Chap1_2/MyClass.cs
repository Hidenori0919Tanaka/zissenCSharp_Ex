using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1_2
{
    public class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int XDubou { get { return X * 2; } }
        public int YDouble { get { return Y * 2; } }
    }

    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int XDouble { get { return X * 2; } }
        public int YDouble { get { return Y * 2; } }
    }
}
