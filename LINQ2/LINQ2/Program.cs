using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementcount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementcount];
            Console.Write("Введите элементы  массива:\t");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            var result = myArray.Where(item => item > 9 && item < 99)
                                .OrderBy(item => item);
            Console.WriteLine("Отсортированная последовательность:\t ");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
