using System;

namespace TechCafé.RecordTypes.Equality
{
    public record Person(string FirstName, string LastName, string[] PhoneNumbers);

    public class Equality
    {
        public static void DoWork()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Nancy", "Davolio", phoneNumbers);
            Person person2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }
    }
}