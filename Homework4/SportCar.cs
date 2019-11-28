using System;


namespace Homework4
{
    public class SportCar : Car
    {
        public string Name = "Sport Car";
        public void Ride()
        {
            Go(Name, CarSpeed(new Random(), 500, 800));
        }
    }
}

