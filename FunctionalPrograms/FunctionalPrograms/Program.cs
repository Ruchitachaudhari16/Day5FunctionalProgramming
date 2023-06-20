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
            Console.WriteLine("3:Largest Number Program");
            Console.WriteLine("4:Quotient Remainder Program");
            Console.WriteLine("5:Swapping Number Program");
            Console.WriteLine("6:Vowel Consonent Program");
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

                    case 3:
                    Console.WriteLine("The Largest Number Program");
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.checkLargestNumber();
                    break;

                    case 4:
                    Console.WriteLine("The Quotient Remainder Program");
                    QuoRemainder quoRemainder = new QuoRemainder();
                    quoRemainder.CheckQuoRemain();
                    break;

                    case 5:
                    Console.WriteLine("Swapping Number Program:");
                    SwapNumber swapNumber = new SwapNumber();
                    swapNumber.swapNumbers();
                    break;

                    case 6:
                    Console.WriteLine("Vowel Consonent Program:");
                    VowelConsonent vowelConsonent = new VowelConsonent();
                    vowelConsonent.checkVowelConsonant();
                    break;
            }
            Console.ReadLine();
        }
    }
}
