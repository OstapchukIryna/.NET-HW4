using System;


namespace Homework4
{
    public class Bus : Car
    {
        public string Name = "Bus";
        public void Ride()
        {
            Go(Name, CarSpeed(new Random(), 800, 1100));
        }
    }
}

