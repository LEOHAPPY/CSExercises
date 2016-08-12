using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            // input a number and then convert it to double;
            // but if I input a character  ? 
            string A = Console.ReadLine();
            double B = Convert.ToDouble(A);
            
            //call the function and print      
            Console.WriteLine(SQRT(B));
        }

        //function
        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            x = Math.Sqrt(x);
            return x;
        }
    }
}
