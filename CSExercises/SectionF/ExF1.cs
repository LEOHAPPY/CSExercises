using System;

namespace CSExercises
{
    //A company records its monthly sales information in an array 
    //of size 12; where Sales[0] represents January sales, Sales[1] is 
    //February sales etc.  After entering the data the company wants to 
    //perform some queries on the data.  Write a program that would do the following:

    //a.Take in the sales for the 12 months.
    //  Note: You may use the array initialisation inside the program for storing these.
    //b.Print the month when Maximum Sales is recorded.
    //  Note: You may just print 0, 1 etc.  for Jan Feb etc… 
    //c.Print the month where Minimum Sales is recorded.
    //d.Print the average monthly sales for the year.

    //There are at least two ways to implement this:
    //1. Implement one method that calculate all the required info in one pass
    //2. Implement 3 methods each calculating different thing

    public class ExF1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input all the sales of months once using tab as a gap");
            Console.WriteLine("Jan.\tFab.\tMar.\tApr.\tMa.\tJun.\tJul.\tAug.\tSep.\tOct.\tNev.\tDec");
            string inputOnce = Console.ReadLine();

            // call SectionF(namespace) InputOnceTime(class) SplitInputInt(method) 
            // splitInput to Int Array to generate sales.
            int[] sales = SectionF.InputOnceTime.SplitInputInt(inputOnce);

            int min = CalculateMinMonth(ref sales);
            int max = CalculateMaxMonth(ref sales);
            double avg = CalculateAvgSales(ref sales);

            Console.WriteLine("Maximum Sales: " + max);
            Console.WriteLine("Minimum Sales: " + min);
            Console.WriteLine("Average Sales: " + avg);
        }

        public static int CalculateMinMonth(ref int[] sales)
        {
            //YOUR CODE HERE
            int minMonth = sales[0];

            for (int i=1;i<sales.Length;i++)
            {
                minMonth = Math.Min(minMonth,sales[i]);
            }
            return minMonth;

        }

        public static int CalculateMaxMonth(ref int[] sales)
        {
            //YOUR CODE HERE
            int maxMonth = sales[0];
            for (int i = 1; i < sales.Length; i++)
            {
                maxMonth = Math.Max(maxMonth, sales[i]);
            }
            return maxMonth;
        }

        public static double CalculateAvgSales(ref int[] sales)
        {
            //YOUR CODE HERE
            //sum
            int sumSales = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                sumSales = sumSales + sales[i];
            }

            double avgSales = sumSales / sales.Length;
            return avgSales;
        }



    }
}
