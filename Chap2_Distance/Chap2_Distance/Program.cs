using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1,10);
            }

            PrintInchiToMeter(1,10);
        }

        private static void PrintInchiToMeter(int start, int stop)
        {
            for (int inchi = start; inchi < stop; inchi++)
            {
                double meter = FeetConverter.ToMeter(inchi);
                Console.WriteLine("{0} ft = {1:0.0000}m", inchi, meter);
            }
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            //FeetConverter converter = new FeetConverter();
            for (int feet = start; feet < stop; feet++)
            {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}m", feet, meter);
            }
        }



        static void PrintMeterToFeetList(int start, int stop)
        {
            //FeetConverter converter = new FeetConverter();
            for (int meter = start; meter < stop; meter++)
            {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0} ft = {1:0.0000}m", meter, feet);
            }
        }

        
    }
}
