using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  1^3 + 5^3 + 3^3  
    //
    //Confine the input to 3 digit examples only ie., number values 100?99.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input a tree-digit integer");
            string numStr = Console.ReadLine();
            Console.WriteLine("{0} {1} an Armstrong number", numStr, ResultArmstrongNumber(numStr));
        }
        public static string ResultArmstrongNumber(string numStr)
        {
            //YOUR CODE HERE
            //extract every number
            string numStr1 = numStr.Substring(0, 1);
            string numStr2 = numStr.Substring(1, 1);
            string numStr3 = numStr.Substring(2, 1);
            
            //convert to double 
            double num1 = Convert.ToDouble(numStr1);
            double num2 = Convert.ToDouble(numStr2);
            double num3 = Convert.ToDouble(numStr3);
            
            //caculate sum of the trible times of each number
            double tribleSum = Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3);
            
            //condition
            double num = Convert.ToDouble(numStr);
            string resultArmstrongNumber;

            if (num == tribleSum)
            {
                resultArmstrongNumber = "is";
            }
            else
            {
                resultArmstrongNumber = "is not ";
            }

            return resultArmstrongNumber;
        }
    }
}