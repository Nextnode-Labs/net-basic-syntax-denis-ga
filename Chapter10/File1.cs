using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    public partial class MyPartialClass 
    { 
        public void Method1()
        {
            Console.WriteLine("File1");
        }

        partial void PartialMethod();
        partial void MyMethod();
    }
}
