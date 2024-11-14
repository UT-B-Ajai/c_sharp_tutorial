using System;

namespace Learning_c_sharp
{
    public static class DecisionMaking
    {
            static public void DecisionMakingProgram()
            {
                Console.WriteLine("Decision Making Examples");
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even.");
                else
                    Console.WriteLine($"{number} is odd.");

                Console.WriteLine("Switch case example:");
                switch (number % 3)
                {
                    case 0:
                        Console.WriteLine($"{number} is divisible by 3.");
                        break;
                    case 1:
                        Console.WriteLine($"{number} leaves a remainder of 1 when divided by 3.");
                        break;
                    case 2:
                        Console.WriteLine($"{number} leaves a remainder of 2 when divided by 3.");
                        break;
                    default:
                        Console.WriteLine("Unexpected case.");
                        break;
                }
            }
        }
}
