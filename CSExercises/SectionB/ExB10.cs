using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //remind then convert to double 
            Console.WriteLine("Please input the lengthe of the first side:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the lengthe of the second side:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the lengthe of the third side:");
            double c = Convert.ToDouble(Console.ReadLine());
            
            //call the function and display
            string area = CalculateArea(a, b, c);
            Console.WriteLine("result: {0}", area);
        }

        public static string CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            string areaStr;
            if ((a + b) > c && (a - b) < c)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                areaStr = Convert.ToString(area);
            }
            else
            {
                areaStr = "input error";
            }
            return areaStr;
        }
    }
}