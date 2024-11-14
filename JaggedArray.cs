using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_c_sharp
{
    public static class JaggedArray
    {
        static public void JaggedArrayProgram()
        {
            int[][] jaggedArray = new int[5][];

            jaggedArray[0] = new int[1]; 
            jaggedArray[1] = new int[2]; 
            jaggedArray[2] = new int[3];
            jaggedArray[3] = new int[4];
            jaggedArray[4] = new int[5];

            Console.WriteLine("Enter values for the jagged array:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Enter value for position [{i},{j}]: ");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe jagged array is:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
