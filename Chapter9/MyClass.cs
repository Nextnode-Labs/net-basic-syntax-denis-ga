using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter9
{
    class MyClass
    {
        public int myField = 5;
        public ref int GetField()
        {
            return ref myField;
        }
    }
}
