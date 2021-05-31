namespace TechCafé.RecordTypes
{
    public class Immutability
    {
        public record ImmutablePerson1(string Firstname, string Lastname);
    
        public record ImmutablePerson2
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }

        }
    
        public record MutablePerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        };
    }
}