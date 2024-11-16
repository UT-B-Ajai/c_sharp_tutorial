using System;

namespace Learning_c_sharp
{
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    public class Scooter : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Scooter started.");
        }

        public void Stop()
        {
            Console.WriteLine("Scooter stopped.");
        }
    }

    public class Interface
    {
        public static void InterfaceExample()
        {
            IVehicle myScooter = new Scooter();
            myScooter.Start();
            myScooter.Stop();
        }
    }
}
