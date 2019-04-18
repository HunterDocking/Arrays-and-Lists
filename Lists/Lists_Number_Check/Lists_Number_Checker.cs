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

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Ask me a number to check in the list: ");
            int input = int.Parse(Console.ReadLine());
            int count = 0;

            foreach (int i in numbers)
            {
                if (i == input)
                {
                    count++;
                }
            }

            if (count >= 1)
            {
                Console.WriteLine("The number " + input + " is in your list");
                Console.WriteLine("The number " + input + " appears " + count + " times in your list");
            } else
            {
                Console.WriteLine("The number " + input + " does not exist in your list");
            }
        Console.ReadKey(true);
        }
    }
}