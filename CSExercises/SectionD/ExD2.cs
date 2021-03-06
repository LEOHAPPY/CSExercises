using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.
    
    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            //remind and receive and convert
            Console.WriteLine("Please input number A");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please input number B");
            int b = Convert.ToInt16(Console.ReadLine());

            //call the function to calculate

            int hcf=1;
            double lcm=1;
            Euclid(a, b, ref hcf, ref lcm);

            //output 
            Console.WriteLine("The HCF of these two numbers is {0}\nand their LCM is {1}", hcf, lcm);
            
        }
        public static void Euclid(int a, int b, ref int hcf, ref double lcm)
        {
            int larger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            while (larger != smaller)
            {
                larger = larger - smaller;

                if (larger < smaller)
                {
                    int term = larger;
                    smaller = larger;
                    smaller = term;
                }
            }

            hcf = larger;
            lcm = (a * b) / hcf;
        }       
    }
}

/*mehtod 1  LEO algrithum 
           //call the function to calculat HCF
           double hcf = Euclid1(a, b);

           double lcm = (a * b) / hcf;

           static double Euclid1(double a,double b)
           {
               double hcf;
               if ((a % b == 0) || (b % a == 0))
               { 
                   hcf = Math.Min(a, b);
               } 
               else if (a == b)
               {
                   hcf = a;
               }
               else hcf = 1;
               return hcf;
           }
           */
