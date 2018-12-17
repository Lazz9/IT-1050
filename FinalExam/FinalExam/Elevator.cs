using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double total = 0;
            foreach (Passenger passenger in Occupants)
            {
                total += passenger.GetWeight();
            }
            return total;
        }
        public bool IsOverMaxCapacity()
        {
            if  (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
