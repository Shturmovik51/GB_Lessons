using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_L5_2.MyConsoleWork;
using System.Text.RegularExpressions;

namespace HW_L5_2.MyMessage
{
    public class Message
    {
        /// <summary>
        /// вывод слов из N символов
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        public void LessOrN(string str, int n)
        {
            string pattern = "(\\n| )\\w{" + n + "}(\\b)";  
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                var matches = regex.Matches(str);
                foreach(var match in matches)
                {
                    Console.WriteLine($"{match}");
                }
            }
            else Console.WriteLine("Нет совпадений");
        }

        /// <summary>
        /// Удаление слов, заканчивающихся на заданный символ (я их просто "закрасил", чтобы наглядней было)
        /// =даже мне больно смотреть на этот метод=
        /// </summary>
        /// <param name="strb">строка</param>
        /// <param name="symbol">символ, на который заканчивается слово в строке</param>
        public void DeletWord(StringBuilder strb, char symbol)
        {            
            int length = strb.Length-1;

            for (int i = 0; i < strb.Length-1; i++)
            {
                if (strb[i] == symbol && char.IsPunctuation(strb[i + 1]) 
                    || strb[i] == symbol && char.IsSeparator(strb[i + 1])
                    || strb[i] == symbol && char.IsControl(strb[i + 1]))                
                {
                    while (i != -1 && !char.IsSeparator(strb[i]))
                    {
                        strb[i] = ' ';
                        i--;
                    }                    
                }
            }

            if (strb[length] == symbol)
            {
                while (strb[length] != ' ')
                {
                    strb[length] = ' ';
                    length--;
                }
            }

            Console.WriteLine($"Получаем:\n{strb}");
        }          

        /// <summary>
        /// Нахождение самого длинного слова
        /// </summary>
        /// <param name="strb"></param>
        public void TheLongestWord(StringBuilder strb)
        {            
            string s = strb.ToString();
            string longestWord = string.Empty;
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > longestWord.Length)
                    longestWord = words[i];

            Console.WriteLine($"Самое длинное слово: {longestWord}");

        }
    }
}
