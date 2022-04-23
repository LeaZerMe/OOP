using System;

namespace OOP_Project
{
    public class Person
    {
        protected string name;
        protected string surname;
        protected int age;
        protected string city;

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string GetName() {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public virtual void ShowInfoAboutPerson()
        {

            Func<string, string> displayPersonsName = (description)
                => description + name + " " + surname;

            Console.WriteLine(displayPersonsName("Full Name: "));
        }
    }
}
