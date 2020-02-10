﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SegregationInterface
{
    class FlyingCar : IFlyingDrivable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Launch the rocket first or this flying car can not get driven.");
            }
            else
            {
                Console.WriteLine("I am flying to {0} miles away ...", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }
}
