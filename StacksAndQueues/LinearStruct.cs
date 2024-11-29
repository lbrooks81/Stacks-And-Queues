using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public abstract class LinearStruct<T>
    {
        protected List<T> items = [];

        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;
        public void Clear() => items.Clear();
        public void Push(T item) => items.Add(item);
        public abstract T Pop();
        public abstract T Peek();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < items.Count; i++)
            {
                sb.Append($"[{i}] {items[i]}\n");
                // \n instead of Environment.NewLine so we can remove the last character regardless of OS
            }

            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1); // Removes the last character
            }

            return sb.ToString();
        }
    }
}
