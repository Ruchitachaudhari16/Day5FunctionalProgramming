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
            int choice=Convert.ToInt32(Console.ReadLine()); 
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("The Leap year Program");
                    Functional functional = new Functional();
                    functional.Check_year();
                    break;
            }
            Console.ReadLine();
        }
    }
}
