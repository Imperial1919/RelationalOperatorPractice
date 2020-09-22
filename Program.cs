using System;

namespace RelationalOperator_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;


            b = 20;
            a = 50;
            c = 50;
            d = 75;
            

            Console.WriteLine(a != b);
            Console.WriteLine(a == b);
            if ( a > b)
            {
                Console.WriteLine("variable a is greater than variable b.");
            }

            if (a < b)
            {
                Console.WriteLine("variable b is greater than variable b.");
            }

            else
            {
                Console.WriteLine("Error.");
            }


            Console.WriteLine(a >= c);
        }
    }
}
