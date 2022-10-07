using System;

namespace CheckedOperator
{     
    public class Class1
    {
        short x = 32767;
        short y = 32767;
        public int CheckedOverFlow()
        {
            int z = 0;
            try
            {
                z = checked((short)(x + y));                
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            return z;
        }
        public int UnCheckedOverFlow()
        {
            int z = 0;
            try
            {                
                z = unchecked ((short)(x + y));
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            return z;
        }
        public int Normal()
        {
            int z = 0;
            try
            {
                z =  x + y;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            return z;
        }
    }
}
