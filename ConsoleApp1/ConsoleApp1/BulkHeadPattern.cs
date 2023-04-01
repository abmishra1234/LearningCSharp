using System;
using System.Threading;
using System.Threading.Tasks;

public class Bulkhead<T>
{
    private SemaphoreSlim _semaphore;
    private readonly int _maxConcurrency;

    public Bulkhead(int maxConcurrency)
    {
        _maxConcurrency = maxConcurrency;
        _semaphore = new SemaphoreSlim(_maxConcurrency);
    }

    public async Task RunAsync(T context, Func<T, Task> action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        await _semaphore.WaitAsync();
        try
        {
            Console.WriteLine($"Starting action ({DateTime.Now.ToString("hh:mm:ss.fff")})");
            await action(context);
            Console.WriteLine($"Finished action ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        }
        finally
        {
            _semaphore.Release();
        }
    }
}


public class Program
{
    static async Task Main(string[] args)
    {
        // Puting error for checking build is firing properly or not?
        jjjjjjj
        int numTasks = 10;
        int completedTasks = 0;
        object lockObj = new object();
        var bulkhead = new Bulkhead<int>(maxConcurrency: 3); // set max concurrency to 3

        for (var i = 0; i < numTasks; i++)
        {
            var taskNum = i; // capture task number in local variable
            var task = new Func<int, Task>(async (context) =>
            {
                try
                {
                    await bulkhead.RunAsync(context, async (ctx) =>
                    {
                        Console.WriteLine($"Starting task {taskNum} ({DateTime.Now.ToString("hh:mm:ss.fff")}) with context {ctx}");
                        await Task.Delay(1000);
                        Console.WriteLine($"Finished task {taskNum} ({DateTime.Now.ToString("hh:mm:ss.fff")}) with context {ctx}");

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

            ThreadPool.QueueUserWorkItem(async _ => await task.Invoke(taskNum));
        }

        Console.ReadLine();
    }
}
