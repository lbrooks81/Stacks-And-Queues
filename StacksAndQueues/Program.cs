namespace StacksAndQueues
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Testing stack...");
            Stack<String> stack = new Stack<String>();
            TestLinearStructure(stack);

            Console.WriteLine("\nTesting queue...");
            Queue<String> queue = new Queue<String>();
            TestLinearStructure(queue);
        }
        private static void TestLinearStructure(LinearStruct<String> ls)
        {
            ls.Push("Bob");
            ls.Push("Stuart");
            ls.Push("Kevin");
            ls.Push("Gru");

            Console.WriteLine(ls);

            Console.WriteLine($"Peek: {ls.Peek()}");
            Console.WriteLine($"Pop: {ls.Pop()}");

            Console.WriteLine($"Peek: {ls.Peek()}");
            Console.WriteLine($"Pop: {ls.Pop()}");

            Console.WriteLine(ls);
            Console.WriteLine($"Count: {ls.Count}");

            Console.WriteLine("Clearing stack...");
            ls.Clear();

            Console.WriteLine($"IsEmpty: {ls.IsEmpty}");
        }
    }
}
