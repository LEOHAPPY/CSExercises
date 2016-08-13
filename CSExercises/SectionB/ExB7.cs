using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //receive and convert into double type
            Console.WriteLine("Please input the distance");
            double basicCharge = Convert.ToDouble(Console.ReadLine());

            //call the function and display formatlly
            Console.WriteLine("S${0:0.00}", CalculateFare(basicCharge));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double fare = 2.40 + distance * 0.4;
            return fare;
        }
    }
}
