using System;

namespace _1_Single_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                This class no longer violates the SRP.
                We have separated out several classes, each of which has one function,
                which could plausibly be changed in isolation.

                NB this app still isn't SOLID! For example, Dependency Inversion is
                broken, as a Person is instantiated directly inside Main().
            */

            //Welcome message
            Messages.WelcomeMessage();

            //Get required user information
            Person user = PersonDataCapture.Capture();

            //Validate user information
            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid)
            {
                Messages.ExitMessage("");
                return;
            }

            //Generate Username
            AccountGenerator.CreateAccount(user);
            Messages.ExitMessage("");
            return;
        }
    }
}
