﻿namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //list.Add(70);
            //list.Add(30);
            //list.Add(56);

            //list.Display();

            //list.Append(56);
            //list.Append(30);
            //list.Append(70);

            //list.Display();
            list.Append(56);
            list.Append(70);
            list.Display();
            list.Insert(30, 56);
            list.Display();
            list.DeleteFirst();
            list.Display();

            //list.Deletelast();
            //list.Display();
        }
    }
}