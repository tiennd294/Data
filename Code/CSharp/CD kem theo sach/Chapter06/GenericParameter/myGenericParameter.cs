using System;
namespace GenericParameter
{
    class myGenericParameter<T>
    {
         public void Print(T output)
            {
                Console.WriteLine("T={0}", output);
            }        
    }
}
