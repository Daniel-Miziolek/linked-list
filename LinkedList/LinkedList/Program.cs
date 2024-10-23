using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(4);
            list.Append(11);
            list.Display();

            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            for (int i = 0; i < 10; i++)
            {
                list3.Append(i);
            }

            Console.WriteLine(list.Length());
            Console.WriteLine(list2.Length());
            Console.WriteLine(list3.Length());

            Console.WriteLine("List 3 before removal: ");
            list3.Display();
            list3.Remove(4);
            Console.WriteLine("List 3 after removal: ");
            list3.Display();

            list2.Remove(0);

            LinkedList list4 = new LinkedList();
            list4.Append(1);
            list4.Append(2);
            list4.Append(3);
            list4.Prepend(0);

            for (int i = 0; i < list4.Length(); i++)
            {
                Console.WriteLine(i);
            }

            list4.Clear();

            Console.WriteLine(list4.Length());
        }
    }    
}
