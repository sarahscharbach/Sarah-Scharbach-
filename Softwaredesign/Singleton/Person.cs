using System;

namespace Aufgabe_6_Singleton
{
    public class Person
    {
        public string Name;
        public int Age;
        public int Id;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Id = IDGenerator.Instance.GibMirNeId();
            Program.personen.Add(this);
            
        }

        public override string ToString()
        {
            return "Name:" + Name + ", Age: " + Age + ", " + "Id: " + Id;
        }
    }
}