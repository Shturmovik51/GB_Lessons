using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HW_6.HW_6_3
{
    class TableOfStudents
    {
        public void ListSearcher()
        {
            int numOfbakalavr = 0;
            int numOfmagistr = 0;

            StreamReader sr = new StreamReader("students_1.csv");
            List<string[]> table = new List<string[]>();
            List<string> list18to20stud = new List<string>();
            List<int> temp = new List<int>();

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] lines = sr.ReadLine().Split(';');

                    table.Add(lines);

                    if (int.Parse(lines[6]) < 5) numOfbakalavr++; else numOfmagistr++;
                    if (int.Parse(lines[5]) >= 18 && int.Parse(lines[5]) <= 20) list18to20stud.Add($"{lines[1]} {lines[0]} {lines[5]}");

                    temp.Add(int.Parse(lines[5]));
                }
                catch
                {
                }
            }
            sr.Close();

            Console.WriteLine("Список студентов\n");
            ArrayPrinter(table);

            Console.WriteLine($"Магистров: {numOfmagistr}");
            Console.WriteLine($"Бакалавров: {numOfbakalavr}");
            Console.WriteLine($"Студентов 18-20 lvl: {list18to20stud.Count}");

            Console.WriteLine("\nCписок студентов 18-20 lvl:");
            foreach (var line in list18to20stud)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\nОтсортированный список студентов по возрасту:");   //По сортировке:
            temp.Sort();                            // Создал массив столбца возрастов, отсортировал
            ArraySorter(table, temp);               // Передал основную таблицу и отсортированный массив в метод сортировки
            Console.ReadKey();
        }
        /// <summary>
        /// Метод сортировки
        /// </summary>
        /// <param name="table">Изначальный массив для сортировки</param>
        /// <param name="temp">отсортированный массив возрастов</param>
        public void ArraySorter(List<string[]> table, List<int> temp)
        {
            int count = 0;                                          //Счетчик
            List<string[]> sortedTable = new List<string[]>();      //Массив студентов, который должен получиться отсортированным

            while (count < temp.Count)
            {
                for (int i = 0; i < table.Count; i++)
                {
                    if (int.Parse(table[i][5]) == temp[count])      //Сравниваю 6й элемент каждой строки table
                    {                                               //с i-той строкой массива возрастов, если есть совпадение,
                        sortedTable.Add(table[i]);                  //переписываю строку в итоговый массив sortedTable,
                        table.Remove(table[i]);                     //удаляю строку из table, чтобы не повторялась, count++;
                        count++;                        
                    }
                }
            }
            ArrayPrinter(sortedTable);            
        }

        public void ArrayPrinter(List<string[]> arrayToPrint)
        {
            foreach (string[] lines in arrayToPrint)
            {
                foreach (string line in lines)
                {
                    Console.Write($"{line} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }

}
