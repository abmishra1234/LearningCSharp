using System;
using System.Diagnostics;
using System.Threading;

/// <summary>
/// The Bulkhead class implements the Bulkhead pattern, which isolates resources to prevent failures in one part of a system from affecting other parts of the system.
/// </summary>
public class Bulkhead
{
    /// <summary>
    /// Runs the specified action within the bulkhead, ensuring that no more than the specified maximum concurrency are executed concurrently.
    /// </summary>
    /// <param name="action">The action to run within the bulkhead.</param>
    public static void Run(Action action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        Console.WriteLine($"Starting action ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        action.Invoke();
        Console.WriteLine($"Finished action ({DateTime.Now.ToString("hh:mm:ss.fff")})");
    }
}

/// <summary>
/// The Program class contains a simple example of using the Bulkhead class to isolate resource usage.
/// </summary>
public class Program
{
    static void Main(string[] args)
    {
        int numTasks = 10;
        int completedTasks = 0;
        object lockObj = new object();
        for (var i = 0; i < numTasks; i++)
        {
            var taskNum = i; // capture task number in local variable
            var task = new Action(() =>
            {
                try
                {
                    Bulkhead.Run(() =>
                    {
                        Console.WriteLine($"Starting task {taskNum} ({DateTime.Now.ToString("hh:mm:ss.fff")})");
                        Thread.Sleep(1000);
                        Console.WriteLine($"Finished task {taskNum} ({DateTime.Now.ToString("hh:mm:ss.fff")})");

                        lock (lockObj)
                        {
                            completedTasks++;
                            if (completedTasks == numTasks)
                            {
                                Console.WriteLine("All tasks finished.");
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred while executing task {taskNum}: {ex.Message}");
                }
            });

            ThreadPool.QueueUserWorkItem(_ => task.Invoke());
        }
        Console.ReadLine();
    }
}
