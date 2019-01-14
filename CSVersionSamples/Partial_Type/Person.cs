using System;

namespace CSVersionSamples.Partial_Type
{
    partial class Person
    {
        public string FirstName { get; set; } = "John";
        public string Surname { get; set; } = "Doe";
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-(int)(GetRandom() * 100));
        public double Savings { get; set; } = (GetRandom() * 1000.0f);

    }
}
