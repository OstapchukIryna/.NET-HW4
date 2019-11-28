using System;


namespace Homework4
{
    public class CargoCar : Car
    {
        public string Name = "Cargo Car";
        public void Ride()
        {
            Go(Name, CarSpeed(new Random(), 700, 1000));
        }
    }
}
