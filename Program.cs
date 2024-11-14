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
                //case "5":
                //    Function.JaggedArrayExample();
                //    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
