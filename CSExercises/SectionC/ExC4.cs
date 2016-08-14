using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            //Your code here
            Console.WriteLine("Please input the distance(km)");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total fare is S${0:0.00}", CalculateFare(distance));


        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            //round distance 
            double fare;
            distance = Math.Ceiling(10*distance)/10;
            //caculate fare
            if (distance <= 0.5)
            {
                fare = 2.40;
            }
            else if (distance <= 9)
            {
                fare = 2.40 + (10 * distance - 5) * 0.04;
            }
            else
            {
                fare = 2.40 + 85 * 0.04 + (10 * distance - 90) * 0.05;
            }
            //round to 0.01 S$
            //fare = Math.Ceiling(fare)*1000/1000;
            return fare;
        }
    }
}