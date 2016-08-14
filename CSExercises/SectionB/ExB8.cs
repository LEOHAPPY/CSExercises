using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Please input the distance");
            double basicCharge = Convert.ToDouble(Console.ReadLine());

            //call the function and display formatlly
            Console.WriteLine("S${0:0.0}", CalculateFare(basicCharge));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double fare = 2.40 + distance * 0.4;
            fare = Math.Ceiling(fare*10)/10;//same as ExA5
            return fare;
        }
    }
}
