using System;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operators");
            float x = 3 + 2;
            Console.WriteLine("3 + 2 = " + x);
            x = 3 - 2;
            Console.WriteLine("3 - 2 = " + x);
            x = 3 * 2;
            Console.WriteLine("3 * 2 = " + x);
            x = 3 / 2;
            Console.WriteLine("3 / 2 = " + x);
            x = 3 % 2;
            Console.WriteLine("3 % 2 = " + x);
            x = 3 / (float)2;
            Console.WriteLine("3 / 2 = " + x);

            Console.WriteLine("Comparison Operators");
            bool b = (2 == 3);
            Console.WriteLine("2 == 3 = " + b);
            b = (2 != 3);
            Console.WriteLine("2 != 3 = " + b);
            b = (2 > 3);
            Console.WriteLine("2 > 3 = " + b);
            b = (2 < 3);
            Console.WriteLine("2 < 3 = " + b);
            b = (2 >= 3);
            Console.WriteLine("2 >= 3 = " + b);
            b = (2 <= 3);
            Console.WriteLine("2 <= 3 = " + b);

            Console.WriteLine("Logical Operators");
            b = (true && false);
            Console.WriteLine("true && false = " + b);
            b = (true || false);
            Console.WriteLine("true || false = " + b);
            b = !(true);
            Console.WriteLine("!(true) = " + b);
        }
    }
}
