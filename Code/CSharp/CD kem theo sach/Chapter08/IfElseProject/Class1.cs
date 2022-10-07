using System;
using System.Collections.Generic;
using System.Text;

namespace IfElseProject
{
    class Class1
    {        
        public long subtract(int i, int j)
        { 
            int result = 0;
            if (i > j)
                result = i - j;
            else
                result = j - i;
            return result;
        }
        public long subtract2(int i, int j)
        {
            int result = 0;
            result=(i>j)?i - j:j - i;
            return result;
        }
    }
}
