using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceMembers
{
    public class Person
    {
        public string FirstName, LastName;

        internal static int TotalPopulation;

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName} {TotalPopulation}");
        }

        public static void PrintTotalPopulation()
        {
            Console.WriteLine($"Total population is: {TotalPopulation}");
        }

        public static void PrintPerson(Person p)
        {
            Console.WriteLine($"Person: {p.FirstName} {p.LastName}");
        }

        public static int GetARandomNumber()
        {
            return 100034343;
        }
    }
}
