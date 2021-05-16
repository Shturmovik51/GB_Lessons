using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6.HW_6_2
{
    public delegate double AnyFunc(double x);

    class MinOfFunc
    {
        public List<AnyFunc> myFunc = new List<AnyFunc>();        
        
        public void SaveFunc(AnyFunc func, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                x += h;
            }
            bw.Close();
            fs.Close();            
        }
            //Возвращение массива методом Load сделал, впиливать в консоль не стал, чтоб не спамила
        public double[] Load(string fileName, out double min)   
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);                      

            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;

            double[] values = new double[fs.Length];

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {                
                d = bw.ReadDouble();                
                values[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return values;
                        
        }
        public double Function1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public double Function2(double x)
        {
            return Math.Pow(x,3) + Math.Sin(x);
        }
        public double Function3(double x)
        {
            return (Math.Sqrt(x) * 23)/Math.Log(x);
        }

        public void MakeCollectoinOfFunc()
        {
            myFunc.Add(Function1);
            myFunc.Add(Function2);
            myFunc.Add(Function3);
        }

    }
}

