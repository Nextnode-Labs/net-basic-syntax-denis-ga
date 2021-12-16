using System;

namespace Chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop");

            //while
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("\ndo-while");
            //do-while
            int j = 0;
            do
            {
                Console.WriteLine(j++);
            }
            while (j < 10);

            Console.WriteLine("\nfor-loop");
            //for-loop
            for(int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            //foreach loop
            Console.WriteLine("\nForeach loop");

            int[] m = { 1, 2, 3, 4 };
            foreach(int l in m)
            {
                Console.WriteLine(l);
            }

            //for break and continue
            Console.WriteLine("For break and continue");
            for(int y = 0; y < 5; y++)
            {
                if (y == 5) break;
                if (y == 1) continue;
                Console.Write(y);
            }
        }
    }
}
