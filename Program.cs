
using ThreadsExample;

Thread thread = new(new ThreadStart(ThreadFuncshons.ThreadExample));

Console.WriteLine("Id for the primary thread {0} \n", Thread.CurrentThread.GetHashCode());
Console.WriteLine("Start for the primary thread..");

thread.Start();

Console.WriteLine(Thread.CurrentThread.GetHashCode());


Console.ForegroundColor = ConsoleColor.Gray;

for (int i = 0; i < 10; ++i)
{
    Thread.Sleep(25);
    Console.Write("-");
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nPrimary finished");
Console.ReadLine();