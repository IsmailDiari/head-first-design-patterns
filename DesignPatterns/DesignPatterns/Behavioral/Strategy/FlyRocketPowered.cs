﻿using System;

namespace HeadFirstDesignPatterns.Behavioral.Strategy
{
    internal class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}