using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_L5_1.MyConsoleWork
{
    public class MyConsole
    {        
        /// <summary>
        /// Проверка ввода логина.
        /// </summary>
        public void StartProgram()
        {
            Console.WriteLine("Введите свой Логин (2-10 символов без пробелов)");
            bool isPassed = false;
            string login = "";

            while (!isPassed)
            {
                login = FoolProtectionInputString();
                      
                string pattern = @"\d{1}";
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(login[0].ToString()))
                {
                    Console.WriteLine("Логин не должен начинаться с цифры");                  
                }
                else if (login.Length < 2)
                {
                    Console.WriteLine("Слишком короткий логин");
                }
                else if (login.Length > 10)
                {
                    Console.WriteLine("Слишком длинный логин");
                }
                else
                    isPassed = true;
            }
            Console.WriteLine($"Здравствуйте, {login}");            
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
