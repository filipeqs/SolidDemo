namespace DIPDemo
{
    public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; }
        bool IsCompleted { get; set; }

        void CompleteChore();
        void PerformWork(double hours);
    }
}