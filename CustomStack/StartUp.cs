namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            StackOfStrings stack2 = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            stack2.Push("5");
            stack2.Push("6");

            stack.AddRange(stack2);

        }
    }
} 