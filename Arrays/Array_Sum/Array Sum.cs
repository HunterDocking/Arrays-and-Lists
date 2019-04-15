using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0};

            int i = 0;
            int sum = 0;

            while (i < array.Length)
            {
                Console.Write(array[i] + " ");
                sum = sum + array[i];
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(sum);

            Console.ReadKey(true);
        }
    }
}