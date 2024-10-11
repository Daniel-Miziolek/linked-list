using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            Node temp = head;
            Console.WriteLine(temp.Data);
            while (temp.Next != null)
            {
                temp = temp.Next;
                Console.WriteLine(temp.Data);
            }
        }

        public int Length()
        {
            Node temp = head;
            if (head == null)
                return 0;
            int count = 1;
            while (temp.Next != null)
            {
                temp = temp.Next;
                count += 1;
            }
            return count;
        }

        public void Remove(int index)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty!");
                return;
            }
            if (index >= Length() || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            if (index == 0)
            {
                head = head.Next;
                return;
            }
            Node temp = head;
            int position = 0;
            while (temp.Next != null)
            {
                Node previous = temp;
                temp = temp.Next;
                if (position + 1 == index)
                {
                    previous.Next = temp.Next;
                    return;
                }
                position += 1;
            }
        }
    }
}
