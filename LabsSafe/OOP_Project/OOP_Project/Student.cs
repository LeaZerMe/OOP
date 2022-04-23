using System;

namespace OOP_Project
{
    public class Student : Person
    {
        protected string UniversityAccessPassword;
        protected string courseName;
        protected int studyingYear;

        public Student(string name, string surname, string password) : base(name, surname)
        {
            UniversityAccessPassword = password;
        }

        public override void ShowInfoAboutPerson()
        {
            base.ShowInfoAboutPerson();
            Console.WriteLine("Student of University, Faculty: " + courseName + ", " + studyingYear + " year");
        }

        public bool Equals(Student obj)
        {

            if (name == obj.name && surname == obj.surname 
                    && UniversityAccessPassword == obj.UniversityAccessPassword) {
                return true;
            }

            return false;
        }
    }
}
