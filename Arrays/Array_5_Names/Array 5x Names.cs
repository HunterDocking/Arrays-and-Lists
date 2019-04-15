using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameCount = 0;
            int i = 0;

            string[] names = new string[5];

            while (nameCount < names.Length)
            {
                Console.Write("Please enter name " + (nameCount + 1) + ": ");
                names[nameCount] = Console.ReadLine();
                nameCount++;
            }
            while (i < names.Length)
            {
                Console.Write("Hello " + names[i] + "! ");
                i++;
            }

            Console.ReadKey(true);
        }
    }
}