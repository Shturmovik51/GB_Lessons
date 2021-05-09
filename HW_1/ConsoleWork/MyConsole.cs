using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_1.Methods;
using HW_1.Arrais;

namespace HW_1.ConsoleWork
{
    class MyConsole
    {
        MyMethods methods = new MyMethods();
        MyArrais arrais = new MyArrais();
        public void HwSwitcher()
        {
            Console.WriteLine("Что делаем?" +
                              "\n1: Нахождение количества пар элементов массива, в которых только одно число делится на 3" +
                              "\n2: Работа с массивом определенного размера" +
                              "\n3: Работа с двумерным массивом");

            switch (FoolProtectionInput())
            {
                case 1:
                    Console.WriteLine("1: Создать новый массив\n2: Считать массив из файла");
                    int choise = FoolProtectionInput();
                    if (choise == 1)
                    {
                        int[] array1 = arrais.NewRandomArray(20);
                        HW1and2Solution(array1);
                    }
                    if (choise == 2) 
                    {
                        int[] array2 = arrais.ArrayFromFile();
                        HW1and2Solution(array2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор\n");
                        HwSwitcher();
                        break;
                    } 
                    
                case 2:
                    Console.WriteLine("Введите размер массива");
                    int range = FoolProtectionInput();
                    Console.WriteLine("Введите начальное значение в массиве");
                    int firstNum = FoolProtectionInput();
                    Console.WriteLine("Введите шаг заполнения");
                    int step = FoolProtectionInput();
                    int[] array3 = arrais.ArrayWithRange(range, firstNum, step);
                    int[] storedArray = methods.Save(array3);
                    methods.ArrayToString(array3);
                    HW3Solution(array3, storedArray);
                    break;

                case 3:
                    Console.WriteLine("Введите количество строк массива");
                    int row = FoolProtectionInput();
                    Console.WriteLine("Введите количество столбцов массива");
                    int column = FoolProtectionInput();
                    int[,] array4 = arrais.TwoDimArray(row, column);
                    methods.TwoDimArrayToString(array4);
                    HW5Solution(array4);
                    break;

                default:
                    Console.WriteLine("Неверный выбор\n");
                    HwSwitcher();
                    break;
            }
        }

        public void HW1and2Solution(int[] ar)
        {
            methods.ArrayToString(ar);
            int answer = methods.PairsMultiple3(ar);
            Console.WriteLine($"Ответ: {answer}\n");
            HwSwitcher();
        }

        public void HW3Solution(int[] array, int[] storedAr)
        {           
           
            Console.WriteLine("Какую задачу решать?" +
                              "\n1: Сумма всех элементов массива" +
                              "\n2: Новый массив с измененными знаками всех элементов" +
                              "\n3: Умножить все элементы масива на число" +
                              "\n4: Вернуть начальный массив" +
                              "\n5: В начало программы");
            
            switch (FoolProtectionInput())
            {                

                case 1:
                    Console.WriteLine($"Сумма = {methods.SummOfElements(array)}\n");
                    HW3Solution(array, storedAr);
                    break;
                case 2:
                    int[] tempArray1 = methods.InverseArray(array);
                    Console.WriteLine("\nНовый массив:\n");
                    methods.ArrayToString(tempArray1);
                    HW3Solution(array, storedAr);
                    break;
                case 3:
                    Console.WriteLine("на какое число умножать?");
                    int h = FoolProtectionInput();
                    int[] tempArray2 = methods.Multi(array, h);
                    Console.WriteLine("\nНовый массив:\n");
                    methods.ArrayToString(tempArray2);
                    HW3Solution(array, storedAr);
                    break;
                case 4:
                    array = methods.Save(storedAr);
                    Console.WriteLine("\nИзначальный массив\n");
                    methods.ArrayToString(array);
                    HW3Solution(array, storedAr);
                    break;
                case 5:
                    HwSwitcher();
                    break;
                default:
                    Console.WriteLine("Неверный выбор\n");
                    HW3Solution(array, storedAr);
                    break;
            }
        }

        public void HW5Solution(int[,] array)
        {
            Console.WriteLine("Какую задачу решать?" +
                              "\n1: Сумма всех элементов массива" +
                              "\n2: Сумма всех элементов массива больше заданного числа" +
                              "\n3: Минимальное значение элемента в массиве" +
                              "\n4: Максимальное значение элемента в массиве" +
                              "\n5: К началу программы");

            switch (FoolProtectionInput())
            {
                case 1:                   
                    Console.WriteLine($"Сумма = {methods.SummOfElem2Dim(array)}\n");
                    HW5Solution(array);
                    break;
                case 2:
                    Console.WriteLine($"Введите число");
                    int num = FoolProtectionInput();
                    Console.WriteLine($"Сумма = {methods.SummOfElem2Dim2(array, num)}\n");
                    HW5Solution(array);
                    break;
                case 3:
                    string choise1 = "min";
                    int min = methods.MinMaxElem2Dim(array, choise1);
                    (int a1, int b1) = methods.ReturnIndex(array, min);
                    Console.Write($"Min значение = {min}   индекс [{a1},{b1}]\n\n");
                    HW5Solution(array);
                    break;
                case 4:
                    string choise2 = "max";
                    int max = methods.MinMaxElem2Dim(array, choise2);
                    (int a2, int b2) = methods.ReturnIndex(array, max);
                    Console.Write($"Min значение = {max}   индекс [{a2},{b2}]\n\n");
                    HW5Solution(array);
                    break;
                case 5:
                    HwSwitcher();
                    break;
                default:
                    Console.WriteLine("Неверный выбор\n");
                    HW5Solution(array);
                    break;
            }
        }

        public int FoolProtectionInput()
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

    }
}
