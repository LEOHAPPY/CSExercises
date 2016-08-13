using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000   ???rounded to 3 decimal places
    //25	    5       ???rounded to 3 decimal places
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string number1 = Console.ReadLine();
            double number2 = Convert.ToDouble(number1);
            Console.WriteLine("{0}",SQRT(number2));
        }

        public static double SQRT(double number)
        {
            //YOUR CODE HERE: return the square root of x and then use String.Format 
            //to format it. The format is similar to WriteLine
            number = Math.Sqrt(number);
            double roundNumer = Math.Round(number,3);
            return roundNumer;

        }
    }
}
