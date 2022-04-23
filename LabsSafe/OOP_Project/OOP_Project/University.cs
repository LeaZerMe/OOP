using System;
using System.Collections.Generic;

namespace OOP_Project
{

    public delegate void TravelsFunctions(TravelTour instance);

    class University
    {
        public WorkUnity workUnity;
        private int _maxAmountOfTickets = 30;
        private static List<TravelTour> _travelDestinations;

        public void InitializeWorkUnity(WorkUnity workUnity)
        {
            this.workUnity = workUnity;
        }

        public int DisplayMaxAmountOfTickets()
        {
            double ticketsAmountInDouble = _maxAmountOfTickets;
            Func<double> ticketsFunction = () => ticketsAmountInDouble * ticketsAmountInDouble;

            Console.WriteLine(Convert.ToInt32(Math.Sqrt(ticketsFunction())));

            return Convert.ToInt32(Math.Sqrt(ticketsFunction()));
        }

        TravelsFunctions AddTravelDestination = delegate (TravelTour s)
        {
            _travelDestinations.Add(s);
        };

        TravelsFunctions RemoveTravelDestination = delegate (TravelTour s)
        {
            _travelDestinations.Remove(s);
        };
    }
}
