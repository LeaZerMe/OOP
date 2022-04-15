using System;

namespace OOP2
{
    class Person
    {
	    int id;
        int age;
        string name;
        string city;
        int height;
        int weight;

        public Person(int age, string name, string city)
        {
            this.age = age;
            this.name = name;
            this.city = city;
            //this.height = height;
            //this.weight = weight;
        }

        public virtual void displayInfo() {
            Console.WriteLine(this.name + " " + this.age + ", " + this.city);
        }

        public int getAge() {
            return age;
        }

        public string getName()
        {
            return name;
        }

        public string getCity()
        {
            return city;
        }
    }
}
