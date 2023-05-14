using System;
using System.Threading.Tasks;

namespace AsyncPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting async task...");
            await DoAsyncWork();
            Console.WriteLine("Async task completed!");
        }

        static async Task DoAsyncWork()
        {
            Console.WriteLine("Async task is running...");
            await Task.Delay(3000); // Simulate some work being done asynchronously
            Console.WriteLine("Async task completed its work.");
        }
    }
}