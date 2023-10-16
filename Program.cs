using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int temp;

            a = 87;
            b = 45; 

            temp = a;
            a =b;
            b= temp;

            Console.WriteLine("\nAfter swapping: ");
            Console.WriteLine("\n a: " + a);
            Console.WriteLine("\n b: " + b);

            Console.Read();


            

        }
    }
}
