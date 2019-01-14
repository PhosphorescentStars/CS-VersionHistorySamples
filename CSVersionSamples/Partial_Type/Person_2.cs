using System;
using System.Collections.Generic;
using System.Text;

namespace CSVersionSamples.Partial_Type
{
    partial class Person
    {
        private static double GetRandom() => new Random().NextDouble();

        public int GetAge() => DateTime.Now.DayOfYear < BirthDate.DayOfYear
            ? DateTime.Now.Year - BirthDate.Year - 1
            : DateTime.Now.Year - BirthDate.Year;                
    }
}
