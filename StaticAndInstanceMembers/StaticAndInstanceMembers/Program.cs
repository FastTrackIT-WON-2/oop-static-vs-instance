using System;

namespace StaticAndInstanceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Doe";
            Person.TotalPopulation = 1;

            Person person2 = new Person();
            person2.FirstName = "Mary";
            person2.LastName = "Doe";
            Person.TotalPopulation = 2;

            person1.Print();
            person2.Print();
            Person.PrintTotalPopulation();

            // Console.WriteLine($"Person 1: {person1.FirstName} {person1.LastName} {Person.TotalPopulation}");
            // Console.WriteLine($"Person 2: {person2.FirstName} {person2.LastName} {Person.TotalPopulation}");
        }
    }
}
