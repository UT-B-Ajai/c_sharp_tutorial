using System;

namespace Learning_c_sharp
{
    public static class SimpleInterest
    {
            static public void SimpleInterestProgram()
            {
                Console.WriteLine("Simple Interest Calculation");
                Console.WriteLine("Enter the value of p:");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of r:");
                int r = int.Parse(Console.ReadLine());

                int si = (p * n * r) / 100;
                Console.WriteLine($"Simple Interest: {si}");
            }
        }
}
