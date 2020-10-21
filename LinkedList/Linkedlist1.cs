﻿using System;
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

            }

        }
        public void Insert(int pos, int Data)
        {
            if (pos < 1)
            {
                Console.WriteLine("Invalid position");

            }
            else
            {
                if (pos == 1)
                {
                    Node node = new Node(Data);

                    node.next = head;
                    head = node;

                }
                else
                {

                    Node node = new Node(Data);
                    Node temp = head;
                    for (int i = 2; i < pos; i++)
                    {
                        temp = temp.next;
                    }

                    node.next = temp.next;
                    temp.next = node;

                }
            }
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
                    Console.Write(temp.data + "\t");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}
