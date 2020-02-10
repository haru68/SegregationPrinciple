using System;
using System.Collections.Generic;
using System.Text;

namespace SegregationInterface
{
    class Car : IDrivable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }
    }
}
