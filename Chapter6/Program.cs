using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");

            int[] x = new int[3];
            int[] y = new int[] { 1, 2, 3 };
            int[] z = { 1, 2, 3 };


            //Rectangular Arrays

            string[,] xx = new string[2, 2];
            xx[0, 0] = "00"; xx[0, 1] = "01";
            xx[1, 0] = "10"; xx[1, 1] = "11";

            string[,] yy = { { "00", "01" }, { "10", "11" } };
        }
    }
}
