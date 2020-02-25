using System;

namespace _1_Single_Responsibility
{
    public static class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            var random = new Random();
            string randomDigit = random.Next(0, 9).ToString();
            string userName = user.FirstName.Substring(0, 1) + user.LastName + randomDigit;

            Messages.AccountCreationMessage(userName);
        }
    }
}