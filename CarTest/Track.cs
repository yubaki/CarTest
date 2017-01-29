using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    class Track : Car
    {
        private int maxCapacity;
        private int capacity;

        public Track()
        {
            maxCapacity = 100;
            capacity = 0;
        }

        public void LoadLuggage(int LuggageCapacity)
        {
            if (maxCapacity <= (capacity + LuggageCapacity))
            {
                Console.Out.WriteLine("荷物を積みました。");
                capacity += LuggageCapacity;
            }

            else
            {
                Console.Out.WriteLine("これ以上荷物を積めません。");
            }
        }

        public void LowerLuggage(int LuggageCapacity)
        {
            if (0 <= (capacity - LuggageCapacity))
            {
                Console.Out.WriteLine("荷物を下ろしました。");
                capacity -= LuggageCapacity;
            }

            else
            {
                Console.Out.WriteLine("これ以上荷物を下ろせません。");
            }
        }
    }
}
