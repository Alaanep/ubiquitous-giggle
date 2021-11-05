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


		//ToDO: use this method to change property values
        public void PutPeopleInBus(int people, int seats)
        {
            //Add code here so all 8 tests would pass!

            //According to number of people and number of seats calculate:
            //how many Busses are needed and
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


            //some tips: 
            // 20 / 10 = 2
            //25 / 10 = 2
            //25.0 / 2.0 = 12.5
            //24 % 5 = 4
            //Math.Ceiling(0.2) = 1, Ceiling rounds up to smallest int
        }
    }
}
