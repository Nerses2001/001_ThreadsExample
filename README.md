# 001_ThreadsExample
# Example of Working with Threads in C#

This project demonstrates an example of working with threads in C# for multithreaded task execution.

## Code

```csharp
namespace ThreadsExample
{
    internal class ThreadFunctions
    {
        public static void ThreadExample()
        {
            Console.WriteLine("Start the secondary Thread");
            Console.WriteLine("Id for secondary Thread: {0}", Environment.CurrentManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 10; ++i) 
            {
                Thread.Sleep(25);
                Console.Write(".");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Secondary thread finished");
        }
    }
}

using ThreadsExample;

Thread thread = new(new ThreadStart(ThreadFunctions.ThreadExample));

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
```
## Description

The program creates two threads: the main thread and the secondary thread. The main thread starts the secondary thread and prints the identifier of the main thread. Then both threads perform their work in parallel: the main thread prints "-", and the secondary thread prints ".". At the end of execution, the threads display a message indicating the completion of their work.

## Concept of a "Thread"

A thread in programming is a single stream of control within a process. Threads allow operations to be performed in parallel, which enhances program performance. In this example, multithreading is used to execute the task in parallel, where the main thread and the secondary thread work independently of each other, outputting characters to the console.
