
using System;
using System.Collections;
using System.Collections.Generic;

namespace Inherittest
{

    public class Stack
    {
        List<object> myList = new List<object>();

        public void Push(object obj)
        {
            myList.Add(obj);
        }

        public object Pop()
        {
            //var myVal = 

            return myList[0];
        }

        public void Clear()
        {
            
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var stack = new Stack();
            stack.Push("Hello world");

            Console.WriteLine(stack.Pop());
            
        }
    }
}
