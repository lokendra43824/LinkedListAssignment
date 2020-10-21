using System;
using System.Collections.Generic;


namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");
            // Linkedlist1 list = new Linkedlist1();
            //* list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();*//
            //Console.WriteLine("Search element" + list.search(30));
            Linkedlist1 linkedList = new Linkedlist1();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
           // linkedLis.Peek();




        }
    }
}
