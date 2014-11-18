using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_emi
{
    class Program
    {
        static void Main(string[] args)
        {

            string palle;
            Console.WriteLine("Skrive en rad för att kontrolera om det är ett palindrom");
            palle = Console.ReadLine();
            string palle2 =  Reverse(palle);

            if (palle == palle2)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Thohej!! {0} är ett Palindrome", palle);
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Nä du {0} är inte ett Palindrome",palle);
                Console.ResetColor();
            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
