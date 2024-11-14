using System;


namespace Learning_c_sharp
{
    public static class SingleDimensional
    {
        static public void SingleDimensionalArray()
        {
            int size = 5;
            int[] numbers = new int[size];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Number {i + 1}: ");
                //numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers[i] = int.Parse((Console.ReadLine()));
            }

            Console.WriteLine("\nYou entered:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        }
}
