using System;

namespace _1_Single_Responsibility
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person person = new Person();

            Messages.DataCaptureRequest("first name");
            person.FirstName = Console.ReadLine();

            Messages.DataCaptureRequest("last name");
            person.LastName = Console.ReadLine();

            return person;
        }
    }
}