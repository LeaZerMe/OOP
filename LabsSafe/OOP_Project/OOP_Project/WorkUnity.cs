using System;
using System.Collections.Generic;

namespace OOP_Project
{
    class WorkUnity
    {
        private List<Student> _members = new List<Student>();

        public void SignUpNewMember(Student member)
        {
            _members.Add(member);
        }

        public bool IsPersonRegistered(Student student) {

            foreach (Student stud in _members)
            {
                if(stud.Equals(student))
                {
                    return true;
                }
            }

            return false;
        }

        public WorkUnity()
        {

        }
    }
}
