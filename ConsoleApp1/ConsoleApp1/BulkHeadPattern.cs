using System;
using System.Threading;
using System.Threading.Tasks;

public class Bulkhead
{
    private SemaphoreSlim _semaphore;

    public Bulkhead(int maxConcurrency)
    {
        _semaphore = new SemaphoreSlim(maxConcurrency);
    }

    public async Task RunAsync(Func<Task> action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        await _semaphore.WaitAsync();
        try
        {
            Console.WriteLine($"Starting action ({DateTime.Now.ToString("hh:mm:ss.fff")})");
            await action();
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
        int numTasks = 10;
        int completedTasks = 0;
        object lockObj = new object();
        var bulkhead = new Bulkhead(3); // maxConcurrency = 3

        for (var i = 0; i < numTasks; i++)
        {
            var taskNum = i; // capture task number in local variable
            var task = Task.Run(async () =>
            {
                try
                {
                    await bulkhead.RunAsync(async () =>
                    {
                        Console.WriteLine($"Starting task {taskNum} ({DateTime.Now.ToString("hh:mm:ss.fff")})");
                        await Task.Delay(1000);
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

            await task;
        }

        Console.ReadLine();
    }
}
