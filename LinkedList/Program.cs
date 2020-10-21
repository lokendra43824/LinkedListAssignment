using System;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList ");

            LinkedList linkedList = new LinkedList();
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
        }
    }
}