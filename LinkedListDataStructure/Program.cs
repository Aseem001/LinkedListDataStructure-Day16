﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListDataStructure
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {           
            LinkedList linkedList = new LinkedList();
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(40);
            linkedList.InsertAtLast(70);
            linkedList.Display();
            linkedList.RemoveNode(40);
            linkedList.Display();
            Console.ReadKey();
        }
    }
}
