using System;

namespace CSExercises
{
    ///Write a C# program that would keep prompting you to enter an integer number over and over again until you enter the number 88. If you enter 88 the computer should say: 
  	//	“Lucky you…” 
    //and exit the program.


    public class ExD1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //remind and receive and convert
            Console.WriteLine("Please input an integer number");
            int intNum = Convert.ToInt16(Console.ReadLine());
            
            //conditional loop
            while (intNum != 88)
            {
                Console.WriteLine("Please input again");
                intNum = Convert.ToInt16(Console.ReadLine());
            }

            //output
            Console.WriteLine("Lucky you...");
        }
    }
}


/*if command to control loop
bool compare = true;
while (compare)
{
    Console.WriteLine("Please input again");
    intNum = Convert.ToInt16(Console.ReadLine());
    if (intNum == 88) compare = false;
}
*/
