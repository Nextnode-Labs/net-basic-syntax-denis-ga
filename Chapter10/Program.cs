using System;

namespace Chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class");

            // Accessing Object Members
            //MyRectangle r = new MyRectangle();
            //r.x = 11;
            //r.y = 4;
            //int a = r.GetArea();
            //Console.WriteLine(a);

            //Constructor , Keyword
            MyRectangle r = new MyRectangle(13, 3);
            int a = r.GetArea();
            Console.WriteLine(a);

            MyRectangle r1 = new MyRectangle(9);
            a = r1.GetArea();
            Console.WriteLine(a);
             
            //Partial Class
            MyPartialClass myPartial = new MyPartialClass();
            myPartial.Method1();
            myPartial.Method2();

            //Partial Method
        }
    }

    class MyRectangle
    {
        int x, y;

        //Constructor
        //public MyRectangle(int width , int height)
        //{
        //    x = width;
        //    y = height;
        //}

        //This Keyword
        public MyRectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Constructor Overloading
        public MyRectangle() { x = 10; y = 5; }
        public MyRectangle(int a) { x = a; y = a; }

        public int GetArea()
        {
            return x * y;
        }
    }
}
