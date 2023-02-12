using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchLineArrayValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string[] array1 = null;
                Console.WriteLine("Введите любое предложение:");
                string stringNumber = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(stringNumber))
                    array1 = stringNumber.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                else continue;
                Console.Clear();
  
            }

           
        }
    }
}
