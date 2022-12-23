using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first range number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter last range number");
            int y =int.Parse(Console.ReadLine());
            bool prime = true;
            int j ;
            for (int i = x; i <= y; i++)
            {
                for ( j = 1; j < i; j++)
                {
                    if (i%j==0)
                    {
                        prime = false;
                    }
                }
                if (prime == true)
                {
                    Console.WriteLine("the prime numbers are :" + j);
                }
                else prime = true;
            }
            Console.ReadKey();
        } 
    }
}
