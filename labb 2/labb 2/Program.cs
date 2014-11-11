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

            string numbers;
            int counteaven = 0;
            int countuneaven = 0;
            int countzero = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Stoppa in ett heltal");
               

                numbers = Console.ReadLine();
                int.Parse(numbers);

                foreach (int item in numbers)
                {
                    switch (item % 3)
                    {
                        case 0:
                            countzero++;
                            break;
                        case 1:
                            countuneaven++;
                            break;
                        case 2:
                            counteaven++;
                            break;
                    }
                }

                Console.WriteLine("Du har mattat in {0} jämnatal, {1} ojämnatal och {2} nollor", counteaven, countuneaven, countzero);

            }
        }
    }
}