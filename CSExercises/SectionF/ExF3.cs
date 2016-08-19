using System;
using System.Threading;

namespace CSExercises
{
    //The marks of students are stored in a two dimensional array with 
    //the subjects represented in columns and the students in the rows. 
    //That is Row 1 would pertain to Student 1 and the scores that this student 
    //has obtained is stored in various columns in row 1.  Assuming that there are 
    //12 students in a class and 4 subjects, write a program that would do the following:
    //  a.Compute the total marks obtained each student.
    //  b.Compute the class average and standard deviation* of Marks for each subject.
    //  c.Determine the overall average of marks for the whole class for each subjects.

    //Note:   
    //calculation of standard deviation is not required for first time exercise 
    //you may only compute the average – those needing additional practice 
    //may compute standard deviation)

    //Standard Deviation is square root of variance where Variance is given by:
    //	VARIANCE = { [SUM OF(Xi - M)2] / N }; i = 1 to N
    //      N is number of data elements(Xi) and
    //      M is mean(average). 

    public class ExF3
    {
        public static void Main(string[] args)
        {
            int[,] table = new int[,]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            int[] sumMarks = new int[table.GetLength(0)];
            double[] avgMarks = new double[table.GetLength(0)];
            double[] variance = new double[table.GetLength(0)];
            double avgOverAll = 0;
            sumMarksMd(table, ref sumMarks, ref avgMarks,ref avgOverAll,ref variance);

            //Print
            Console.WriteLine("NO\tsumMarks\tavgMarks\tvariance");
            Print(table, sumMarks, avgMarks, variance);
            Console.WriteLine("The overall average of the all the student is {0:0.00}", avgOverAll);



        }
        public static void sumMarksMd(int[,] table,ref int[] sumMarks, ref double[] avgMarks,ref double avgOverAll,ref double[] variance) 
        {
            
            //sumMark for each student
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    sumMarks[i] = sumMarks[i] + table[i, j];
                }
            }

            //avg
            for (int i = 0; i < table.GetLength(0); i++) 
            {
                avgMarks[i] = sumMarks[i] / table.GetLength(1);
            }

            //overall avg

            double avgMarksOverAll = 0;
            for (int i = 0; i < avgMarks.Length; i++)
            {
                avgMarksOverAll = avgMarksOverAll + avgMarks[i];
            }
            avgOverAll = avgMarksOverAll / avgMarks.Length;

            //SD
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    variance[i] = Math.Pow((table[i, j] - avgMarks[j]), 2) / table.GetLength(1);
                }
            }

        }


        public static void Print(int[,] table,int[] sumMarks,double[] avgMarks,double[] variance)
        {
            for(int i = 0; i<table.GetLength(0);i++)
            {
                Console.Write("{0}\t",i+1);
                Console.Write(sumMarks[i] + "\t");
                Console.Write("\t"+avgMarks[i] + "\t");
                Console.WriteLine("\t"+variance[i] + "\t");
            }
            Console.WriteLine();
                
        }
    }
}
