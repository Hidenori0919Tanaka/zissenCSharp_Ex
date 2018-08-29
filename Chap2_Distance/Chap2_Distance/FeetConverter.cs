﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_Distance
{
    public static class FeetConverter
    {
        private const double ratio = 0.3048;
        private const double inchiNum = 0.0254

        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }

        public static double inchiTometer(double inchi)
        {
            return inchi * inchiNum;
        }
    }
}