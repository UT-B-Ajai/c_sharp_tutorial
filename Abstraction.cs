using System;

namespace Learning_c_sharp
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Abstraction
    {
        public static void AbstractionExample()
        {
            Shape myCircle = new Circle(5);
            Console.WriteLine($"Area of the circle: {myCircle.GetArea():F2}");
        }
    }
}
