using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_L5_3.MyConsoleWork
{
    public class MyConsole
    {
        /// <summary>
        /// Сравнивание строк.
        /// </summary>
        public void StringComparer()
        {
            Console.WriteLine("Введите первую строку");
            string str1 = FoolProtectionInputString();
            Console.WriteLine("Введите вторую строку");
            string str2 = FoolProtectionInputString();
            Console.WriteLine("Является ли одна строка перестановкой другой по шаблону: (badc является перестановкой abcd)");

            if (str1.Length == str2.Length && str1.Length%2 == 0)
            {
                bool allGood = true;
                for (int i = 0; i < str1.Length; i+=2)
                {
                    if(str1[i] != str2[i+1] || str1[i+1] != str2[i])
                    {                       
                        Console.WriteLine("Ответ: не является");
                        allGood = false;
                        break;
                    }                    
                }       
                if(allGood) Console.WriteLine("Ответ: является");
            }
            else
                Console.WriteLine("Ответ: не является");
        }

        /// <summary>
        /// защита ввода строки (проходят только буквы и цифры)
        /// </summary>
        /// <returns></returns>
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
