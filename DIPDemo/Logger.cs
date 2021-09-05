using System;
namespace DIPDemo
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: { message }");
        }
    }
}
