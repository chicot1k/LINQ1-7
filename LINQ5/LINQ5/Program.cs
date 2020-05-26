using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ5
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
            var result = from item in myArray
                         where item  >= 1
                         select item;
            result = result.Select(selected => (selected % 10));
            result = result.Distinct();
            Console.WriteLine("Отсортированная последовательность:\t ");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
