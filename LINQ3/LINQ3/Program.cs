using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var Mylist = new List<string>();
            Console.WriteLine("Введите количество элементов: \t");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива: \t");
            for (int i = 0; i < n; i++)
            {
                Mylist.Add((Console.ReadLine()));
            }
            var result = from item in Mylist
                          orderby item.Length ascending
                          select item;
            result.ThenByDescending(s => s);
            Console.WriteLine("Отсортированная последовательность: \t");
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
