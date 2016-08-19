//using System;

//namespace CSExercises
//{
//    //The C# language gives facilities for changing cases all to upper or lower - 
//    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
//    //Example
//    //“institute of systems science”   =>   “Institute Of System Science”

//    public class ExG3
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Please enter a phrase: ");
//            string phrase = Console.ReadLine();

//            string newphrase = ToTitleCase(phrase);

//            Console.WriteLine(newphrase);
//        }

//        public static string ToTitleCase(string phrase)
//        {
//            //YOUR CODE HERE
//            string result;
//            string[] phraseSplit = phrase.Split(' ');
//            string[] toTitle = new string[phraseSplit.Length];

//            for (int i = 0; i < phraseSplit.Length; i++) 
//            {
//                for (int j = 0; j < phraseSplit[j].Length; j++)
//                {
//                    if (j == 0)
//                    {
//                        toTitle[j] = phraseSplit[i-32];
//                    }
//                    else
//                        toTitle[j] = phraseSplit[j];
//                }
//            }








//            return result;


//        }
//    }
//}
