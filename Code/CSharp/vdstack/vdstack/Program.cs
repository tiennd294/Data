using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace vdstack
{
    class Program
    {
        public static void InGiaTri(IEnumerable myCollection)
        {
            IEnumerator myEnumerator = myCollection.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.WriteLine("{0} ", myEnumerator.Current);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Stack myStack = new Stack(); // khởi tạo 1 thể hiện của stack
            for (int i = 0; i < 8; i++) // đẩy 8 giá trị nguyên vào stack
                myStack.Push(i * 9);
            Console.WriteLine("Cac tri trong myStack:\t");
            InGiaTri(myStack); //in ra các giá trị trong stack

            //đẩy 1 phần tử ra khỏi stack
            Console.WriteLine("\nDa day ra\t{0}", myStack.Pop());
            //cho hiển thị nội dung của myStack sau khi đẩy 1 phần tử
            Console.WriteLine("Cac gia tri trong myStack:\t");
            InGiaTri(myStack);
            //đẩy tiếp một phần tử nữa ra khỏi stack
            Console.WriteLine("\nDa day ra\t{0}", myStack.Pop());

            //cho hiển thị nội dung của myStack sau khi đẩy 1 phần tử
            Console.WriteLine("Cac gia tri trong myStack:\t");
            InGiaTri(myStack);

            //cho mình xem phần tử đầu tiên, lưu ý là mình không muốn đẩy nó khỏi stack
            Console.WriteLine("Peek:\t{0}", myStack.Peek());
            //cho hiển thị nội dung của myStack sau khi xem phần tử
            Console.WriteLine("Cac gia tri trong myStack:\t");
            InGiaTri(myStack);

            //khai báo 1 mảng chứa 12 phần tử
            Array myArray = Array.CreateInstance(typeof(int), 12);
            //gán giá trị cho mảng
            for (int i = 0; i < myArray.Length; i++)
                myArray.SetValue(100 * i, i);
            //cho tui xem các giá trị trong mảng
            Console.WriteLine("Mang cua toi:");
            InGiaTri(myArray);

            //chép nội dung của myStack lên myArray
            //đi từ chỉ số 6
            myStack.CopyTo(myArray, 6);

            //cho tui xem giá trị của mảng lúc này
            Console.WriteLine("Mang sau khi duoc sao chep tu stack:");
            InGiaTri(myArray);
            Console.ReadLine();
        
        }
      
    }
}
