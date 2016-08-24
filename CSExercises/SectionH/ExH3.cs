using System;

namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and return the hexadecimal.  

        //Print out the Hex of all numbers 1 to 100 and 

        //compare your answer with that of the built in function.


       static char[] rule = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };

       public static void Main()
        {
            Console.WriteLine("please input an integer");
            int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(printHex());
            Console.WriteLine(Hex(input));
        }

        public static string Hex(int x)
        {
            //YOUR CODE HERE
            string hex = "";
            string hexSplit = "";

            int remainder = 0;

            do
            {
                remainder = x % 16;
                if (remainder < 10)
                {
                    hexSplit = remainder.ToString();
                }
                else if (remainder >= 10)
                {
                    hexSplit = Convert.ToString(rule[remainder - 10]);
                }
                hex = hexSplit + hex;
                x = (x - remainder) / 16;
            } while (x >= 16);

            hex = x + hex;
           
            return hex;
        }
        
    }
}
