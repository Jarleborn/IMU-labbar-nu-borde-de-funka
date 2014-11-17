using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            int nextnumbers = 0;
            Console.WriteLine("Ange hur många numer som ska matas in:");
            int numberOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; numberOfNumbers > i; i++)
            {
                Console.WriteLine("Mata in numer {0}", i + 1);
                int holder = int.Parse(Console.ReadLine());

                if (holder > numbers && holder > nextnumbers)
                {
                    nextnumbers = numbers;
                    numbers = holder;

                }
                else if (holder > nextnumbers)
                {

                    nextnumbers = holder;

                }
            }
            Console.WriteLine("Det näst största värdet är {0}", nextnumbers);
        }


    }
}