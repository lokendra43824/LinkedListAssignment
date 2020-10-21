/*using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace dataStructures
{
    public class LinkedlistStack
    {
        private Node top;
        public LinkedlistStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is the top of the stack", this.top.data);
        }
        /*internal void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("valued popped is {0}", this.top.data);
            this.top = this.top.next;*/

     //   }
   // }

