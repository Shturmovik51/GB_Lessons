using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6.HW_6_1
{
    public delegate double Fun(double x, double c);

    class TableOfFunc
    {
        public static void Table(Fun f, double xMin, double xMax, double c)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (xMin <= xMax)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", xMin, f(xMin, c));
                xMin += 1;
            }
            Console.WriteLine("---------------------");
        }
       
        public static double MyFunc1(double x, double c)
        {
            return c * Math.Pow(x, 2);
        }
        public static double MyFunc2(double x, double c)
        {
            return c * Math.Sin(x);
        }
       
    }
}
