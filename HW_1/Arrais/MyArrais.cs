using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1.Arrais
{
    class MyArrais
    {
        public int[] NewRandomArray(int range)
        {
            int[] array = new int[range];

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                int a = rnd.Next(-10000, 10000);
                array[i] = a;
            }
            return array;
        }

        public int[] ArrayFromFile()
        {
            string file = "NewFile.txt";
            string[] strArray = new string[0];

            if (File.Exists(file))
            {
                strArray = File.ReadAllLines(file);
            }
            else
                Console.WriteLine("Файла не существует");

            int[] numsArray = Array.ConvertAll(strArray, int.Parse);
            return numsArray;
        }

        public int[] ArrayWithRange(int range, int firstNum, int step)
        {
            int[] array = new int[range];
            int a = firstNum;
            for (int i = 0; i < array.Length; i++)
            {
                if 
                    (i == 0) array[i] = a;
                else
                {
                    a += step;
                    array[i] = a;
                }
            }
            return array;
        }

        public int[,] TwoDimArray (int row, int column)
        {
            int[,] array = new int[row,column];
            Random rand = new Random();
           
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {                    
                    array[i, j] = rand.Next(-200, 200);
                }
            }
            return array;
        }
    }
}
