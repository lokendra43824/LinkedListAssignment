/*using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    class LinkedListQueue
    {
        Node head = null;
        internal void Eneque(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next is null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into Queue", +node.data);
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp is null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}*/
