using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;
            var MyList = new List<int>();
            Console.WriteLine("Введите количество элементов массива:\t");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы  массива:\t");
            for (int i = 0; i < n; i++)
            {
                MyList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var result = from item in MyList
                          where (MyList.IndexOf(item) + 1) % 3 != 0
                          select item;
          
            result = result.Select(s => s * (((MyList.IndexOf(s) + 1) * 2) % 3));
            Console.WriteLine("Отсортированная массив: \t ");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
