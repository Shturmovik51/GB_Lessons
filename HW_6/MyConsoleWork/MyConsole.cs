using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_6.HW_6_1;
using HW_6.HW_6_2;
using HW_6.HW_6_3;

namespace HW_6.MyConsoleWork
{
    public class MyConsole
    {
        MinOfFunc minOfFunc = new MinOfFunc();
        TableOfStudents tableOfStud = new TableOfStudents();
        public void TaskSwitcher()
        {
            Console.WriteLine("Что делаем?\n" +
                "1. Вывод таблицы значений функций с*x^2 и с*sin(x) в диапазоне от a до b\n" +
                "2. Нахождение минимума функций\n" +
                "3. Сортировка списка студентов\n");

            switch (FoolProtectionInputInt())
            {
                case 1:
                    TableOfFuncSolution();
                    break;

                case 2:
                    MinOfFuncSolution();
                    break;

                case 3:
                    TableOfStudSolution();
                    break;


                default:
                    Console.WriteLine("Мимо\n");
                    TaskSwitcher();
                    break;
            }          

        }
        public void TableOfFuncSolution()
        {
            Console.WriteLine("Введите параметры");
            Console.WriteLine("Начальное значение x");
            Console.Write("x(min) = ");
            double xMin = FoolProtectionInputDouble();
            Console.WriteLine("Конечное значение x");
            Console.Write("x(max) = ");
            double xMax = FoolProtectionInputDouble();
            Console.WriteLine("Константу с");
            Console.Write("c = ");
            double c = FoolProtectionInputDouble();

            Fun fun = new Fun(TableOfFunc.MyFunc1);
            Console.WriteLine("Таблица функции c*x^2:");
            TableOfFunc.Table(fun, xMin, xMax, c);

            fun = TableOfFunc.MyFunc2;
            Console.WriteLine("Таблица функции c*Sin(x):");
            TableOfFunc.Table(fun, xMin, xMax, c);
            TaskSwitcher();
        }

        public void MinOfFuncSolution()
        {
            minOfFunc.MakeCollectoinOfFunc();
            Console.WriteLine("Нахождение минимального значения функции на интервале от -100 до 100 с шагом 0.5\n" +
                "Минимальное значение какой функции искать:\n" +
                "1: F(x) = x^2 - 50 * x + 10)\n" +
                "2: F(x) = x^3 + Sin(x)\n" +
                "3: F(x) = (Math.Sqrt(x) * 23)/Math.Log(x)\n" +
                "4: В начало\n");

            switch (FoolProtectionInputInt())
            {
                case 1:
                    AnyFunc anyFunc1 = new AnyFunc(minOfFunc.myFunc[0]);
                    minOfFunc.SaveFunc(anyFunc1, "data.bin", -100, 100, 0.5f);
                    double minimum1;
                    minOfFunc.Load("data.bin", out minimum1);
                    Console.WriteLine($"min = {minimum1}\n");
                    MinOfFuncSolution();
                    break;

                case 2:
                    AnyFunc anyFunc2 = new AnyFunc(minOfFunc.myFunc[1]);
                    minOfFunc.SaveFunc(anyFunc2, "data.bin", -100, 100, 0.5f);
                    double minimum2;
                    minOfFunc.Load("data.bin", out minimum2);
                    Console.WriteLine($"min = {minimum2}\n");
                    MinOfFuncSolution();
                    break; 

                case 3:
                    AnyFunc anyFunc3 = new AnyFunc(minOfFunc.myFunc[2]);
                    minOfFunc.SaveFunc(anyFunc3, "data.bin", -100, 100, 0.5f);
                    double minimum3;
                    minOfFunc.Load("data.bin", out minimum3);
                    Console.WriteLine($"min = {minimum3}\n");
                    MinOfFuncSolution();
                    break;

                case 4:
                    TaskSwitcher();
                    break;

                default:
                    Console.WriteLine("Мимо\n");
                    MinOfFuncSolution();
                    break;
            }
        }

        public void TableOfStudSolution()
        {
            tableOfStud.ListSearcher();
        }

        public int FoolProtectionInputInt()
        {
            bool notFool = false;
            int num = 0;

            while (!notFool)
            {
                notFool = int.TryParse(Console.ReadLine(), out int number);
                if (!notFool) Console.WriteLine("Некорректный ввод");
                num = number;
            }
            return num;
        }

        public double FoolProtectionInputDouble()
        {
            bool notFool = false;
            double num = 0;

            while (!notFool)
            {
                notFool = double.TryParse(Console.ReadLine(), out double number);
                if (!notFool) Console.WriteLine("Некорректный ввод");
                num = number;
            }
            return num;
        }

        
    }
}
