//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSExercises
//{
//    //The marks obtained by five students in Programming course are as below:
//    //  Name        Mark
//    //  John	    63
//    //  Venkat	    29
//    //  Mary	    75
//    //  Victor	    82
//    //  Betty	    55

//    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

//    //c.First report sorted in descending order of the Marks (i.e.student rank)
//    //d.Second report sorted on student names alphabetically.

//    public class ExG4
//    {

//        public static void Main()
//        {
//            //YOUR CODE HERE
//            //string[,] table = new string[,] { { "John","63"}, { "Venkat","29"}, { "Mary", "75"}, {"Victor","82"} , { "Betty","55"} };

//            //string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
//            //int[] mark = new int[] { 63, 29, 75, 82, 55 };
//            int[] mark = new int[] { 3, 2, 1, 4, 0, 5 };

//            printArray(mark);

//            int[] newMark = RankMark(mark);
//            printArray(newMark);
//        }

//        public static int[] RankMark(int[] mark)
//        {

//            for (int greenArrow = 0; greenArrow < mark.Length - 1; greenArrow++)
//            {
//                for (int redArrow = greenArrow + 1; greenArrow < mark.Length; redArrow++)
//                {
//                    if (mark[greenArrow] < mark[redArrow])  //SWAP
//                    {
//                        int temp = mark[greenArrow];
//                        mark[greenArrow] = mark[redArrow];
//                        mark[redArrow] = temp;
//                    }
//                }
//            }
//            return mark;
//        }

//        public static void printArray(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }


//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class ExG4
    {
        public static void Main()
        {
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };

            //PrintArrayInt(mark);
            int[] oldMark = (int[])mark.Clone();
            int[] newMark = Sort(mark);
            //mark = oldMark;
            //PrintArrayInt(newMark);
            //PrintArrayStr(name);

            //int[] record = new int[5] { 2, 4, 1, 0, 3 };
            int[] record = new int[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (oldMark[i] == newMark[j])
                    {
                        record[i] = j;
                    }
                }
            }
            //record = sortarry.recordlocation.record(mark, newMark);

            //PrintArrayInt(record);

            string[] newName = new string[5];
            for (int m = 0; m < 5; m++)
            {
                newName[record[m]] = name[m];
            }

            //PrintArrayStr(newName);

            //Print old and new

            PrintArrayTogather(name, oldMark);
            Console.WriteLine("Ranked by Mark dicreasely ");
            PrintArrayTogather(newName, newMark);
        }

        public static int[] Sort(int[] arr)
        {
            //greenArrow <= arr.Length-2
            for (int greenArrow = 0; greenArrow < arr.Length - 1; greenArrow++)
            {
                for (int redArrow = greenArrow + 1; redArrow < arr.Length; redArrow++)
                {
                    if (arr[redArrow] > arr[greenArrow])
                    {
                        //swapping with a temporary variable
                        int tmp = arr[greenArrow];
                        arr[greenArrow] = arr[redArrow];
                        arr[redArrow] = tmp;
                    }
                }
            }

            return arr;
        }

        public static void PrintArrayTogather(string[] arr1, int[] arr2)
        {
            Console.WriteLine("NAME\tMARK");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + "\t");
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
        }

    }
}
