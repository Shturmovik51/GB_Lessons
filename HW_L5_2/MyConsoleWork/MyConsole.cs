using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HW_L5_2.MyMessage;

namespace HW_L5_2.MyConsoleWork
{
    public class MyConsole
    {
        Message message = new Message();
        /// <summary>
        /// Ввод сообщения.
        /// </summary>
        public void MessageInput()
        {
            Console.WriteLine("Ввести сообщение вручную или загрузить из файла?\n1: вручную   2: из файла");
            StringBuilder strb = new StringBuilder();

            switch (FoolProtectionInputInt())
            {
                case 1:
                    Console.WriteLine("Вводите");
                    strb.Append(Console.ReadLine());
                    break;

                case 2:
                    string temp = "NewFile.txt";
                    if (!File.Exists(temp))
                    {
                        Console.WriteLine("Файла не существует");
                        MessageInput();
                    }
                    else strb.Append(File.ReadAllText(temp));
                    break;

                default:
                    Console.WriteLine("мимо");
                    MessageInput();
                    break;
            }
            StepTwo(strb);
        }
        /// <summary>
        /// Непосредственная работа с сообщением
        /// </summary>
        /// <param name="stringbuilder"></param>
        public void StepTwo(StringBuilder stringbuilder)
        {
            StringBuilder strb = stringbuilder;

            Console.WriteLine($"Сообщение:\n{strb}\n\n Какие действия?\n" +
                $"1: Вывести слова, состоящие из неболее N символов\n" +
                $"2: Удалить из сообщения все слова, которые заканчиваются на заданный символ\n" +
                $"3: Найти самое длинное слово сообщения\n");

            switch (FoolProtectionInputInt())
            {
                case 1:
                    Console.WriteLine("введите N");
                    int n = FoolProtectionInputInt();
                    message.LessOrN(strb.ToString(), n);
                    break;

                case 2:  
                    string temp = "00";

                    while (temp.Length > 1)
                    {
                        Console.WriteLine("введите один символ");                        
                        temp = FoolProtectionInputString();
                    }

                    char sumbol = char.Parse(temp);
                    message.DeletWord(strb, sumbol);
                    break;

                case 3:
                    message.TheLongestWord(strb);
                    break;

                default:
                    Console.WriteLine("Мимо");
                    StepTwo(strb);
                    break;
            }
        }
        /// <summary>
        /// защита от ввода НЕцифр
        /// </summary>
        /// <returns></returns>
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
        public string FoolProtectionInputString()
        {
            string str = null;

            while (str == null)
            {
                str = Console.ReadLine();

                for (int i = 0; i < str.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(str[i]))
                    {
                        Console.WriteLine("Некорректный ввод");
                        str = null;
                        break;
                    }
                }
            }
            return str;
        }
    }    
}
