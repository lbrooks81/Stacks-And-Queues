using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack<T> : LinearStruct<T>
    {
        public override T Pop()
        {
            T item = items[^1];
            items.RemoveAt(items.Count - 1);
            return item;
        }
        public override T Peek() => items[^1];
        
    }
}
