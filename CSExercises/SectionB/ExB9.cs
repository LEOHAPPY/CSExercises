using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9 //the same as ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Please input the distance");
            double basicCharge = Convert.ToDouble(Console.ReadLine());

            //call the function and display formatlly
            Console.WriteLine("S${0:0.00}", CalculateFare(basicCharge));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double fare = 2.40 + distance * 0.4;
            fare = Math.Ceiling(fare * 10) / 10;//same as ExA5 but this time is the nearest 10 cents
            return fare;


        }
    }
}
