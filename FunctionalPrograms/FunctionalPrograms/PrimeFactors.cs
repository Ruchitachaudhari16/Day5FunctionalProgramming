using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PrimeFactors
    {
        public void checkPrimeFactors()
        {
            Console.WriteLine("Enter the number to find prime factor");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; number>1; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }
            }
              

            }
        }
    }


