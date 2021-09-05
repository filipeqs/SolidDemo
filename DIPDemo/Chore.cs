using System;
namespace DIPDemo
{
    public class Chore : IChore
    {
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsCompleted { get; set; }

        readonly ILogger _logger;
        readonly IMessageSender _messageSender;


        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsCompleted = true;

            _logger.Log($"Completed { ChoreName }");

            _messageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
