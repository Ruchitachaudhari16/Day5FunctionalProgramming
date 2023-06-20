using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Program
    {
        public static void  Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1:Leap Year Program:");
            Console.WriteLine("2:Even Odd Program");
            int choice=Convert.ToInt32(Console.ReadLine()); 
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("The Leap year Program");
                    Functional functional = new Functional();
                    functional.Check_year();
                    break;

                    case 2:
                    Console.WriteLine("The Even Odd Program");
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.Check_EvenOdd();
                    break;
            }
            Console.ReadLine();
        }
    }
}
