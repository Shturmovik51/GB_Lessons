using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace HW_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(DateTime);
            var fis = type.GetProperties();   //задача, вывести свойства

            Console.WriteLine($"Свойства структуры DateTime:\n\n" + 
                $"{"Name", -15} {"PropertyType",-20} {"Attributes",-15} {"CanRead",-15} {"CanWrite",-15}\n");

            foreach (var item in fis)
            {
                Console.WriteLine($"{item.Name, -15} {item.PropertyType,-20} {item.Attributes,-15} {item.CanRead,-15} {item.CanWrite,-15}");
            }           
        }
    }
}
