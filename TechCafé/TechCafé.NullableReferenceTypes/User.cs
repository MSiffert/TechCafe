using System;
using System.Collections.Generic;

namespace TechCafé.NullableReferenceTypes
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CityOfBirth { get; set; }
        public DateTime Birthdate { get; set; }
        public double HeightInCm { get; set; }
        public List<string> Residences { get; set; }
        
        public User()
        {
        }
    }
}