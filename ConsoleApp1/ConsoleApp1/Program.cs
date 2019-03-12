using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //My name is Daniil Blair and i am the developer of this program which tells you if thew number entered is odd or even
            Console.WriteLine("This program will determine if the number entered is a odd or even number");
            Console.ReadKey();

            Console.WriteLine("Please enter a whole number and i will tell you if it is odd or even");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine("The num you entered was even");
            else
                Console.WriteLine("The num you habe entered was odd");
            Console.ReadKey();
       
        }
    }
}
