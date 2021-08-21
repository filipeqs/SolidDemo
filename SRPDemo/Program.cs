using System;

namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplicationMessage();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplicationMessage();
        }
    }
}
