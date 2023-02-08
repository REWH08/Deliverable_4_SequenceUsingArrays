/*
Author: Roberto Wong Hernandez
Date: 02/07/2023
Description: C# application that spits out fibonacci sequence
*/

using System.Globalization;

namespace ISM_4300_Fourth_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[26];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            int len = fibonacci.Length;

            Console.WriteLine("Fibonacci Series:");
            Console.WriteLine("");

            for (int i = 0; i < len; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
           
                Console.WriteLine("Fibonacci Number[" + i + "] = " + fibonacci[i]);

            }


        }
    }
}