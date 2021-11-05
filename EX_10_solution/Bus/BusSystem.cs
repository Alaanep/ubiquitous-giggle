using System;
using System.Collections.Generic;
using System.Text;

namespace Bus
{
    public class BusSystem
    {
		
		//public properties: we can use them in tests
        public int NrOfBuses { get; private set; }
        public int NrOfPeople { get; private set; }


		//use this method to change property values
        public void PutPeopleInBus(int people, int seats)
        {
            NrOfBuses = people / seats;
            //do people fit exactly?
            int peopleInLast = people % seats;

            if (peopleInLast == 0) //if people fit exactly
            {
                //number of people in the last bus is equal to the number of seats
                NrOfPeople = seats;
            }
            else
            {   //number of people in the last bus is equal to dividing result
                NrOfPeople = peopleInLast;
                NrOfBuses++;
            }
        }
    }
}
