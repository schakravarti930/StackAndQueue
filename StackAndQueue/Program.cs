using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack Operations
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();

            //Queue Operations
            Queue linkedListQueue = new Queue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}
