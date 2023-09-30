namespace ThreadsExample
{
    internal class ThreadFuncshons
    {
        public static void ThreadExample()
        {
            Console.WriteLine("Start the secondery Thread");
            Console.WriteLine("Id for secondery Thread: {0}", Environment.CurrentManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 10; ++i) 
            {
                Thread.Sleep(25);
                Console.Write(".");
            }
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Secondery thread finished");

        }
    }
}
