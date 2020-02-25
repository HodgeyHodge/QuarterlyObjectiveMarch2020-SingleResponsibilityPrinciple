using System;

namespace _1_Single_Responsibility
{
    public static class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Messages.ValidationFailure("first name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Messages.ValidationFailure("last name");
                return false;
            }

            return true;
        }
    }
}