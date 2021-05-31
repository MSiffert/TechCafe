using System;

namespace TechCafé.RecordTypes.Inheritance
{
    public abstract record Person(string FirstName, string LastName);
    public record Teacher(string FirstName, string LastName, int Grade) : Person(FirstName, LastName);
    public record Student(string FirstName, string LastName, int Grade) : Person(FirstName, LastName);

    public class Inheritance
    {
        public void DoWork()
        {
            Person teacher = new Teacher("Nancy", "Davolio", 3);
            Person student = new Student("Nancy", "Davolio", 3);
            Console.WriteLine(teacher == student); // output: False

            Student student2 = new Student("Nancy", "Davolio", 3);
            Console.WriteLine(student2 == student); // output: True
        }
    }
}