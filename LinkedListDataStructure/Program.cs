// --------------------------------------------------------------------------------------------------------------------
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
            /// UC 4
            LinkedList linkedList = new LinkedList();            
            linkedList.InsertAtLast(56);            
            linkedList.InsertAtLast(70);
            linkedList.InsertAtLast(80);
            linkedList.InsertAtLast(90);
            linkedList.InsertBetween(56, 70, 30);
            linkedList.Display();
            Console.ReadKey();
        }
    }
}
