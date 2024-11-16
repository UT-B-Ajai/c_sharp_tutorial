using System;

namespace Learning_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a function to run:");
            Console.WriteLine("1. Simple Interest Calculation");
            Console.WriteLine("2. Decision Making Examples");
            Console.WriteLine("3. Single-Dimensional Array Example");
            Console.WriteLine("4. Multi-Dimensional Array Example");
            Console.WriteLine("5. Jagged Array Example");
            Console.WriteLine("6. Class And Object Example");
            Console.WriteLine("7. Encapsulation Example");
            Console.WriteLine("8. Inheritance Example");
            Console.WriteLine("9. Polymorphism Example");
            Console.WriteLine("10. Abstraction Example");
            Console.WriteLine("11. Interface Example");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SimpleInterest.SimpleInterestProgram();
                    break;
                case "2":
                    DecisionMaking.DecisionMakingProgram();
                    break;
                case "3":
                    SingleDimensional.SingleDimensionalArray();
                    break;
                case "4":
                    MultiDimensional.MultiDimensionalArray();
                    break;
                case "5":
                    JaggedArray.JaggedArrayProgram();
                    break;
                case "6":
                    ClassAndObject.ClassAndObjectProgram();
                    break;
                case "7":
                    Encapsulation.EncapsulationExample();
                    break;
                case "8":
                    Inheritance.InheritanceExample();
                    break;
                case "9":
                    Polymorphism.PolymorphismExample();
                    break;
                case "10":
                    Abstraction.AbstractionExample();
                    break;
                case "11":
                    Interface.InterfaceExample();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
