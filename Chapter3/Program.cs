using System;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            // однострочный коммент

            /* multi-line
                comment */

            Console.WriteLine("Hello World !");

            //Integer types
            Console.WriteLine("Signed integers");
            sbyte myInt8 = 2;
            Console.WriteLine("sbye : Min : " + sbyte.MinValue + " : Max : " + sbyte.MaxValue);

            short myInt16 = 1;
            Console.WriteLine("short : Min : " + short.MinValue + " : Max : " + short.MaxValue);

            int myInt32 = 0;
            Console.WriteLine("int : Min : " + int.MinValue + " : Max : " + int.MaxValue);

            long myInt64 = -1;
            Console.WriteLine("long : Min : " + long.MinValue + " : Max : " + long.MaxValue);

            Console.WriteLine("Unsigned integers");
            byte uInt8 = 0;
            Console.WriteLine("byte : Min : " + byte.MinValue + " : Max : " + byte.MaxValue);

            ushort uInt16 = 1;
            Console.WriteLine("ushort : Min : " + ushort.MinValue + " : Max : " + ushort.MaxValue);

            uint uInt32 = 2;
            Console.WriteLine("uint : Min : " + uint.MinValue + " : Max : " + uint.MaxValue);

            ulong uInt64 = 3;
            Console.WriteLine("ulong : Min : " + ulong.MinValue + " : Max : " + ulong.MaxValue);

            int myHex = 0xF;
            Console.WriteLine("hexadecimal 0xF = " + myHex);

            int myBin = 0b0100;
            Console.WriteLine("binary 0b0100 = " + myBin);

            Console.WriteLine("Floating-Point Types");
            float myFloat = 3.14F;
            Console.WriteLine("float : Min : " + float.MinValue + " : Max : " + float.MaxValue);

            double myDouble = 3.14;
            Console.WriteLine("double : Min : " + double.MinValue + " : Max : " + double.MaxValue);

            decimal myDecimal = 3.14M;
            Console.WriteLine("decimal : Min : " + decimal.MinValue + " : Max : " + decimal.MaxValue);

            Console.WriteLine("Char Type");
            char c = 'a';
            Console.WriteLine(c);
        }
    }
}
