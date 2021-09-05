using System;

namespace DIPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Filipe";
            owner.LastName = "Silve";
            owner.EmailAddress = "filipe.silva@email.com";
            owner.PhoneNumber = "123456789";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformWork(3);
            chore.PerformWork(1.5);
            chore.CompleteChore();
        }
    }
}
