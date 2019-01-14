using System;
using CSVersionSamples.Partial_Type;

namespace CSVersionSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person();            
            Console.WriteLine($"{person.FirstName} {person.Surname}.\n" +
                $"{person.BirthDate} is now {person.GetAge()} years old" +
                $"\nand has ${person.Savings.ToString("#.##")}");
            Console.ReadLine();
        }
    }
}
