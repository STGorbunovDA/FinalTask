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

                string[] array2 = new string[array1.Length];
                for (int i = 0; i < array1.Length; i++)
                    if (array1[i].Length <= 3)
                        array2[i] = array1[i];

                Console.WriteLine($"Массив строк у которых длинна <=3: ");
                Console.WriteLine(string.Join(" ", array2));
                Console.ReadKey();
                Console.Clear();

            }          
        }
    }
}
