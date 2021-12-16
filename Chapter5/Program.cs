using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings");

            string a = "Hello";

            Console.WriteLine("String Concatenation");
            string b = a + " World";
            Console.WriteLine(b);

            a += " World";
            Console.WriteLine(b);

            string s1 = "Hello";
            string s2 = "World";
            string s = $"{s1} {s2}";
            Console.WriteLine(s);

            Console.WriteLine("Escape Characters");

            string myString = "Hello\nWorld";
            Console.WriteLine("Newline : " + myString);

            myString = "Hello\tWorld";
            Console.WriteLine("Horizontal tab : " + myString);

            myString = "Hello\vWorld";
            Console.WriteLine("Vertical tab : " + myString);

            myString = "Hello\bWorld";
            Console.WriteLine("Backspace : " + myString);

            myString = "Hello\rWorld";
            Console.WriteLine("Carriage return : ");
            Console.WriteLine(myString);

            myString = "Hello\0World";
            Console.WriteLine("Null character : " + myString);

            Console.WriteLine("String Members");

            string a1 = "String";
            string b1 = a1.Replace("i", "o");
            Console.WriteLine("Replace : " + b1);

            b1 = a1.Insert(0, "My ");
            Console.WriteLine("Insert : " + b1);

            b1 = a1.Remove(0, 3);
            Console.WriteLine("Remove : " + b1);

            b1 = a1.Substring(0, 3);
            Console.WriteLine("Substring : " + b1);

            b1 = a1.ToUpper();
            Console.WriteLine("ToUpper : " + b1);

            int i = a1.Length;
            Console.WriteLine("Length : " + i);
        }
    }
}
