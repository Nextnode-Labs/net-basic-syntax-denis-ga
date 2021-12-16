using System;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");

            //If Statement
            int x = new System.Random().Next(3);

            if (x > 1)
                Console.WriteLine(x + ">1");
            else if (x < 1)
                Console.WriteLine(x + "<1");
            else
                Console.WriteLine(x + "=1");


            //Switch Statement
            int y = new System.Random().Next(4);

            string result = x switch
            {
                0 => "zero",
                1 => "one",
                _ => "more than one"
            };
            Console.WriteLine(result);

            //Ternary Operator
            double x1 = new System.Random().NextDouble();
            x1 = (x < 0.5) ? 0 : 1;
            Console.WriteLine(x1);
        }
    }
}
