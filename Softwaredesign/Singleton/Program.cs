using System;
using System.Collections.Generic;

namespace Aufgabe_6_Singleton
{
    class Program
    {
        public static List<Person> personen = new List<Person>();
        static void Main(string[] args)
        {
            new Person("Dieter", 44);
            new Person("Horst", 45);
            new Person("Walter", 33);
            new Person("Karl-Heinz", 22);

            new Person("Brunhilde", 56);
            new Person("Maria", 75);
            new Person("Kunigunde", 22);
            new Person("Tusnelda", 12);

            foreach (var person in personen)
                Console.WriteLine(person);
        }
    }
}