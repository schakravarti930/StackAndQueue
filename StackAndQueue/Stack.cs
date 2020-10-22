using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        public void push(int item)
        {
            Node node = new Node(item);
            if(top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
        }
        public void Display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}
