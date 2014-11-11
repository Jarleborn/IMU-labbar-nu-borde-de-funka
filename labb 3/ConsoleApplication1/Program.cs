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
            string numbers = "";
            Console.WriteLine("Ange hur många numer som ska matas in:");
            int numberOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; numberOfNumbers > i; i++)
            {
                Console.WriteLine("Mata in numer {0}", i+1);
                string holder = Console.ReadLine();
                numbers += holder+";";
            }
            foreach (string item in numbers) { 
            
            }
          
        }
    }
}
