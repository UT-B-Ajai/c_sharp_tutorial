using System;

namespace Learning_c_sharp
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
        }
    }

    public class Car : Vehicle
    {
        public string Model { get; set; }
    }

    public class Inheritance
    {
        public static void InheritanceExample()
        {
            Car myCar = new Car
            {
                Brand = "Toyota",
                Model = "Corolla"
            };
            Console.WriteLine($"Brand: {myCar.Brand}, Model: {myCar.Model}");
            myCar.Honk(); 
        }
    }
}
