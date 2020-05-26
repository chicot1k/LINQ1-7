using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите количество элементов массива A:\t");
            int elementcount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementcount];
            Console.Write("Введите элементы  массива:\t");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите количество элементов массива B:\t");
            int elementcount1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[elementcount1];
            Console.Write("Введите элементы  массива:\t");
            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите K1:\t");
            int K1 = int.Parse(Console.ReadLine());
            Console.Write("Введите K2:\t");
            int K2 = int.Parse(Console.ReadLine());

            var result = from item in myArray
                           where item > K1
                           select item;
            var result2 = from item2 in myArray1
                           where item2 < K2
                           select item2;
            result = result.Union(result2);
            result = result.OrderBy(selected => selected);
            Console.WriteLine("Отсортированная последовательность:\t ");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

    }
    
}
