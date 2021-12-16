using System;

namespace Chapter9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            Program myApp = new Program();
            myApp.MyPrint();
            myApp.MyPrint("Param1", "Param2");
            myApp.MyPrint("Test string");
            myApp.MyPrint(7);

            Console.WriteLine("Pass by Value");
            int x = 0; 
            myApp.Set(x);
            System.Console.WriteLine(x);

            Console.WriteLine("Ref Keyword");
            myApp.Set(ref x);
            System.Console.WriteLine(x);

            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.GetField());
        }

        void Set(int i) { i = 10; }
        void Set(ref int i) { i = 10; }

        void MyPrint()
        {
            Console.WriteLine("Method MyPrint");
        }

        void MyPrint(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }

        void MyPrint(string s)
        {
            Console.WriteLine(s);
        }

        void MyPrint(int i)
        {
            Console.WriteLine("Int : " + i);
        }
    }
}
