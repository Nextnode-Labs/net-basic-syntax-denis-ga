using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    public partial class MyPartialClass 
    {
        public void Method2()
        {
            Console.WriteLine("File2");
        }

        partial void PartialMethod()
        {
            Console.WriteLine("PartialMethod");
        }

        public void CallPartialMethod()
        {
            
        }
    }
}
