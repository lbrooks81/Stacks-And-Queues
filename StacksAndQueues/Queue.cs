using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queue<T> : LinearStruct<T>
    {
        public void Enqueue(T value) => Push(value);
        public T Dequeue() => Pop();

        public override T Pop()
        {
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }
        public override T Peek() => items[0];
    }

}

