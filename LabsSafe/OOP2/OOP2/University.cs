using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class University
    {
        int deliveredTickets;
        int ticketsMaxAmount;
        List<TravelDestnation> travelDestinations;

        University()
        {

        }

        private void setTicketsAmount(int amount)
        {

        }

        public int getTicketsAmount()
        {
            return ticketsMaxAmount;
        }

        public Ticket bookTicket()
        {
            return new Ticket();
        }
    }
}
