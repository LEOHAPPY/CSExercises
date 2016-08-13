using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string cStr = Console.ReadLine();
            Console.WriteLine("{0}", ConvertToFahrenheit(cStr));
        }

        public static double ConvertToFahrenheit(string cStr)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            double c = Convert.ToDouble(cStr);
            double F = 1.8 * c + 32;
            return F;
        }
    }
}
