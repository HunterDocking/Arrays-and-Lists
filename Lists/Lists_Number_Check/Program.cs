using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);


            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine


            Console.ReadKey(true);
        }

    }
}
