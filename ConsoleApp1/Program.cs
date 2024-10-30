using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyApp2
{   
    class Stack<T>
    {
        Stack<T> items = new Stack<T>();
        private T _item;

        public Stack()
        {
        }

        public void Pop()
        { 
            items.Pop();
        }

        public void Push(T item)
        { 
            items.Push(item);
        }
    }
    
    class Box<T>
    {
        private T _item;
        public List<T> items = new List<T>();
        public Box()
        {}
        public void GetItem()
        {
            Console.WriteLine(_item);
        }

        public void SetItem(T item) 
        {
            _item = item;
            items.Add(item);
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Box<int> item = new Box<int>();
            Stack<int> stack = new Stack<int>();
            item.SetItem(34);
            item.GetItem();
            stack.Push(52);
            stack.Pop();
        }
    }
}