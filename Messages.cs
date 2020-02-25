using System;

namespace _1_Single_Responsibility
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Hodgey's Username Generator Console App!");
        }

        public static void ExitMessage(string exitMessage)
        {
            if (!string.IsNullOrWhiteSpace(exitMessage))
            {
                Console.WriteLine(exitMessage);
            }
            Console.ReadLine();
        }

        public static void ValidationFailure(string fieldName)
        {
            Console.WriteLine($"Invalid {fieldName} given!");
        }

        public static void DataCaptureRequest(string fieldName)
        {
            Console.Write($"Please supply {fieldName}: ");
        }

        public static void AccountCreationMessage(string userName)
        {
            Console.WriteLine($"Your Username is \"{userName}\"");
        }
    }
}