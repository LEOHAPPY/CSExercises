using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 1 to 10000.

    public class ExE6
    {
        public static void Main()
        {
            int[] count = new int[1000];
            //calculate how many factors a figure has
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count[i - 1]++;
                    }
                }
            }
            // output the Prime 
            for (int m = 1; m <= 1000; m++)
            {
                if (count[m - 1] == 2)
                {
                    Console.WriteLine(m);
                }
            }

        }
    }
}

