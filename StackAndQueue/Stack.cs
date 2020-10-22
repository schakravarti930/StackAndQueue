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
        public void Push(int item)
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
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
