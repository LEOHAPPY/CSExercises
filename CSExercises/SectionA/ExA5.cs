using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number as 
    //input and prints the number with 2 decimal points in the output.
    //Example: 
    //  Input       Output
    //  100.1	    100.10
    //  0	        0.00
    //  3.232	    3.23
    //  4.555	    4.55


    public class ExA5
    {
        public static void Main(string[] args)
        {
            //read and convert to double type then save in inputDb1
            double inputDbl = Convert.ToDouble(Console.ReadLine());
            /*is the same as the following but more concise and no need a variable to diliver.
            string inputStr = Console.ReadLine();
            double inputDbl = Convert.ToDouble(inputStr);
            */
            double x = Math.Floor(inputDbl * 100) / 100; //4.555 455.5 455 4.55
            Console.WriteLine("{0:0.00}", x);
        }

    }
}
