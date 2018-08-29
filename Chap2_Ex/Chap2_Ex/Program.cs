using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var song1 = new Song("1","1",0);
            var song2 = new Song("2", "2", 1);
            var song3 = new Song("3", "3", 2);

            var songs = new Song[] { song1, song2, song3 };
        }
    }
}
