using System;
using System.Collections.Generic;

namespace OOP2
{
    class Unity<T>
    {
        List<T> _members;

        public virtual List<T> ShowMembers() {
            return _members;
        }

        public virtual void ExplainStateMission()
        {
            Console.WriteLine("Mission Statement For Unity");
        }
    }
}
