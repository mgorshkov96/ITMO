﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpWinForms.Lab06.Exercise01
{
    internal class Operation
    {
        public static double SummSin(int x, double a, double b)
        {
            double res;
            return res = Math.Sin(x * a) + Math.Sin(x * b);
        }
    }
}
