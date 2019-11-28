using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar();
            Bus bus = new Bus();
            CargoCar cargoCar = new CargoCar();
            Automobile automobile = new Automobile();
            List<Thread> threads = new List<Thread>()
            {
                new Thread(cargoCar.Ride),
                new Thread(automobile.Ride),
                new Thread(bus.Ride),
                new Thread(sportCar.Ride)
            };
            foreach (Thread list in threads)
            {
                list.Start();
            }

            Console.ReadKey();
        }
    }
}

