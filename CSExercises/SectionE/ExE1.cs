using System;

namespace CSExercises
{
    //Given a number find out its factorial.  

    //Write two different C# program variations for 
    //the problem:
    //a.Using increment counter
    //b.Using a decrement counter.

    //Carefully study the similarities and differences 
    //between the two approaches.
    //List the conditions, if any, under which your program 
    //is likely to fail

    public class ExE1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact1 = CalculateFactorialInc(n);
            Console.WriteLine(fact1);

            int fact2 = CalculateFactorialDec(n);
            Console.WriteLine(fact2);

            int fact3 = RecurciveMethod(n);
            Console.WriteLine(fact3);
        }

        public static int CalculateFactorialInc(int n)
        {
            //YOUR CODE HERE
            int i = 1;
            int factorial = n;
            for (i = 1; i < n; i++)
            {
                factorial = factorial * i; 
            }
            return factorial;

        }

        public static int CalculateFactorialDec(int n)
        {
            //YOUR CODE HERE
            int i = 1;
            int factorial = n;
            for (i = n-1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static int RecurciveMethod(int n)
        {
            int result;
            if (n == 1)
            {
                result = 1;
            }
            else
            {
                result = n * RecurciveMethod(n - 1); //recursive recall
            }
            return result;
        }
    }
}
