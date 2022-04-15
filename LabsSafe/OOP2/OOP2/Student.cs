using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Student : Person
    {
        string faculty;
        int studyingCourse;

        public Student(int age, string name, string city, string faculty, int course)
            : base(age, name, city)
        {

            this.faculty = faculty;
            this.studyingCourse = course;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Studying: " + this.faculty + ", " + this.studyingCourse + " course\n");
        }
    }
}
