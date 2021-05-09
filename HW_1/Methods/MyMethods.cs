using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1.Methods
{
    class MyMethods
    {
        #region Методы с одномерным массивом
        public int PairsMultiple3(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 ^ a[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void ArrayToString(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,7}", array[i].ToString());
                if ((i + 1) % 10 == 0) Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }

        public int SummOfElements(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }

        public int[] InverseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }
            return array;
        }

        public int[] Multi(int[] array, int h)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= h;
            }
            return array;
        }

        public int[] Save(int[] array)
        {
            int[] stored = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                stored[i] = array[i];
            }
            return stored;
        }
        #endregion

        #region Методы с двумерным массивом
        public void TwoDimArrayToString(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0,5}", array[row, col].ToString());
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }

        public int SummOfElem2Dim(int[,] array)
        {
            int summ = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    summ += array[row, col];
                }
            }
            return summ;
        }
        public int SummOfElem2Dim2(int[,] array, int num)
        {
            int summ = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (array[row, col] > num)
                        summ += array[row, col];
                }
            }
            return summ;
        }

        public int MinMaxElem2Dim(int[,] array, string choise)
        {
            int num = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (choise == "min")
                    {
                        if (array[row, col] < num)
                            num = array[row, col];
                    }
                    else if (choise == "max")
                    {
                        if (array[row, col] > num)
                            num = array[row, col];
                    }
                }
            }
            return num;
        }

        public (int a, int b) ReturnIndex(int[,] array, int num)
        {
            int a=0;
            int b=0;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (num == array[row, col])
                    {
                        a = row;
                        b = col;
                    }                                                              
                }
            }
            return (a, b);
        }

        #endregion
    }
}

