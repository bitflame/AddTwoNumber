using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //    public sealed class LinkedListNode<T>
            //    {
            //    internal LinkedList<T> list;
            //    internal LinkedListNode<T> next;
            //    internal LinkedListNode<T> prev;
            //    internal T item;
            //Create list1 list2 and list3
            int[] numDigits = { 1, 2, 3 };
            int[] numDigits2 = { 5, 6, 8 };
            int carry = 0;
            LinkedList<int> l1 = new LinkedList<int>(numDigits);
            LinkedList<int> l2 = new LinkedList<int>(numDigits2);
            LinkedList<int> l3 = new LinkedList<int>();
            LinkedList<int> dummy = new LinkedList<int>();
            while (l1.First != null && l2.First !=null)
            {  
                l3.AddFirst((l1.Last.Value + l2.Last.Value + carry) % 10);
                carry = (l1.Last.Value + l2.Last.Value + carry) / 10;
                l2.RemoveLast();
                l1.RemoveLast();
                dummy = l3;
            }
            while (l1.First!= null)
            {
              l3.AddFirst((l1.Last.Value + carry)%10);
                carry = ((l1.Last.Value + carry) / 10);
                l1.RemoveLast();
                dummy = l3;
            }
            while (l2.First != null)
            {
              l3.AddFirst((l2.Last.Value + carry)%10);
              carry = (((l2.Last.Value + carry) / 10));
              l2.RemoveLast();
              dummy = l3;
            }
            if (carry != 0)
            {
                Console.WriteLine("Check your code; carry should not be zero at this point");
            }
            while (dummy.First != null)
            {
                Console.WriteLine(dummy.First.Value);
                dummy.RemoveFirst();
            }
            Console.ReadLine();
        }
    }
}
