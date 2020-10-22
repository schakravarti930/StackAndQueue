using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack Operations
            Stack<float> stack = new Stack<float>();
            stack.Push(1.2f);
            stack.Push(32f);
            stack.Push(44.3f);
            stack.Display();

            //Queue Operations
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("There");
            queue.Enqueue("How");
            queue.Display();
        }
    }
}
