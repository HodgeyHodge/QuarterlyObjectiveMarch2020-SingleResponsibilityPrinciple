using System;

namespace _1_Single_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                This is an example of a class which egregiously violates the Single Responsibility Principle.
                This one class deals with:
                    messages to the user
                    input from the user
                    validation
                    username generation
                If any one of these things has to change, Program.cs has to be edited!
            */

            //Welcome message
            Console.WriteLine("Welcome to Hodgey's Username Generator Console App!");

            //Get required user information
            Person user = new Person();
            Console.Write("Please give your first name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Please give your last name: ");
            user.LastName = Console.ReadLine();

            //Validate user information
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("Invalid first name given!");
                Console.ReadLine();
                return;
            }
            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("Invalid last name given!");
                Console.ReadLine();
                return;
            }
            
            //Generate Username
            Console.WriteLine($"Your Username is: {user.FirstName.Substring(0, 1)}{user.LastName}{(new System.Random()).Next(0, 9)}");
            Console.ReadLine();
        }
    }
}
