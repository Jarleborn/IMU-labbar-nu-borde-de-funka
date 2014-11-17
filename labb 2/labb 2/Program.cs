using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers;
            int counteaven = 0;
            int countuneaven = 0;
            int countzero = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Stoppa in ett heltal");
               

                numbers = int.Parse(Console.ReadLine());
              

              
                int[] arrs = Array.ConvertAll(numbers.ToString().ToArray(), x => (int)x - 48);
                foreach (int item in arrs)
                {
                    if (item == 1 || item == 3 || item == 5 || item == 7 || item == 9)
                    {
                       countuneaven++; // antal udda.
                    }
                    else if (item == 2 || item == 4 || item == 6 || item == 8)
                    {
                       counteaven++; // jämna
                    }
                    else
                    {
                        countzero++; // nollor
                    }
                }
                Console.WriteLine("Du har mattat in {0} jämnatal, {1} ojämnatal och {2} nollor", counteaven, countuneaven, countzero);
                break;
            }
            
        } 
    }
}