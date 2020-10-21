using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
                Console.WriteLine("{0} inserted into linked list", node.data);

            }

        }
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
           // Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
