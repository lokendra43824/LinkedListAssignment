﻿using System;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList ");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);

            linkedList.Add(70);
            linkedList.Display();

            linkedList.Insert(2, 30);
            linkedList.Display();


        }
    }
}