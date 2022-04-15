using System;
using System.Collections.Generic;

namespace OOP2
{
    class WorkUnity : Unity<Student>
    {
        private List<Student> _members;

        public override List<Student> ShowMembers()
        {
            return _members;
        }

        public override void ExplainStateMission()
        {
            Console.WriteLine("Mission Statement For Particular Work Unity");
        }
    }
}
