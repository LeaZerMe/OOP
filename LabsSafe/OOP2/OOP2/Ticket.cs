using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Ticket
    {
        string owner;
        string country;
        int price;

        public Ticket() {
        }

        public bool isEmpty()
        {
            return owner.Length > 0;
        }
    }
}
