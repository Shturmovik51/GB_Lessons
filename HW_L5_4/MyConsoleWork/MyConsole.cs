using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HW_L5_4.ListOfStudents;

namespace HW_L5_4.MyConsoleWork
{    
    class MyConsole
    {
        /// <summary>
        /// Метод нахождения 3 мин. средних балла
        /// </summary>
        public void StartSearchingFools()
        {
            string file = "ListOfStudents.txt";                         //скачал список

            StreamReader listOfStudents = new StreamReader(file);       //взял из него число учащихся
            int n = int.Parse(listOfStudents.ReadLine());

            Students[] stud = new Students[n];                          //создал массив студентов на базе созданного класса

            for (int i = 0; i < stud.Length; i++)
            {
                string[] s = listOfStudents.ReadLine().Split(' ');
                stud[i].name = s[0];
                stud[i].surname = s[1];
                stud[i].grade1 = int.Parse(s[2]);
                stud[i].grade2 = int.Parse(s[3]);
                stud[i].grade3 = int.Parse(s[4]);
            }

            float[] mid = new float[stud.Length];                       //создал массив средних баллов

            for (int i = 0; i < mid.Length; i++)
            {
                mid[i] = (float)(stud[i].grade1 + stud[i].grade2 + stud[i].grade3) / 3;
            }

            float[] temp = new float[stud.Length];                      //временный массив для сохранения индексов

            mid.CopyTo(temp, 0);

            Array.Sort(mid);                                            //отсортировал по возрастанию

            Console.WriteLine($"Худшая успеваемость у:\n");             //взял индексы из временного массива на основе сравнения
                                                                        //значений с 3-мя первыми значениями упорядоченного массива
            for (int i = 0; i < temp.Length; i++)                       //(они же 3 минимальных) и вывел имена из массива учащихся
            {                                                           //по индексу
                if (temp[i] == mid[0])
                {
                    Console.WriteLine($"{stud[i].name} {stud[i].surname} {stud[i].grade1} {stud[i].grade2} {stud[i].grade3}\n");
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == mid[1])
                {
                    Console.WriteLine($"{stud[i].name} {stud[i].surname} {stud[i].grade1} {stud[i].grade2} {stud[i].grade3}\n");
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == mid[2])
                {
                    Console.WriteLine($"{stud[i].name} {stud[i].surname} {stud[i].grade1} {stud[i].grade2} {stud[i].grade3}\n");
                }
            }
        }
    }
}
