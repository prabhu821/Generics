using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaxNumber
    {
        //MAX INTEGER NUMBER 
        public static int MaxIntegerNumber(int a, int b, int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
            {
                return c;
            }
            return a;
        }

        //MAX FLOAT NUMBER
        public static double MaxFloatNumber(double a, double b, double c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
            {
                return c;
            }
            return a;
        }
    }
}
