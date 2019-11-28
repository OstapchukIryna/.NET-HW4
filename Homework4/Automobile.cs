using System;


namespace Homework4
{
    public class Automobile : Car
    {
        public string Name = "Automobile";
        public void Ride()
        {
            Go(Name, CarSpeed(new Random(), 600, 900));
        }
    }
}
