using System;

namespace Learning_c_sharp
{
    public class ClassAndObject
    {
        public class Car
        {
            // Properties of the Car class
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public void DisplayCarInfo()
            {
                Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}");
            }
        }

        public static void ClassAndObjectProgram()
        {
            // Create an object of the Car class
            Car myCar = new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2022
            };

            Console.WriteLine("Class and Object Example:");
            myCar.DisplayCarInfo();
        }
    }
}
