using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string xStr = Console.ReadLine();
            Console.WriteLine("{0}", CalculateY(xStr));
        }

        public static double CalculateY(string xStr)
        {
            //YOUR CODE HERE
            double x = Convert.ToDouble(xStr);
            double y = 5 * x * x - 4 * x + 3;
            return y;
        }
    }
}
