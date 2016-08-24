using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

        //Assume: input only characters and with space at the end 

    public class ExG3
    {
        public static void Main(string[] args)
        {

            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            DateTime oTimeBegin = DateTime.Now;

            Console.WriteLine(ToTitleCase(phrase));
            //Console.WriteLine(ToTitleCase2(phrase));
            // record time // just wanna to test speed 
            DateTime oTimeEnd = DateTime.Now;
            TimeSpan oTime = oTimeEnd.Subtract(oTimeBegin);
            Console.WriteLine(oTime.ToString());
        }

        public static char[] ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            //Pretreatment 
            //phrase = phrase.ToLower();
            phrase = phrase.Trim();

            //become to chatArray
            char[] phraseChar = phrase.ToCharArray();

            //lower is more 32 than upper in ASICAA
            phraseChar[0] = (char)(phraseChar[0] - 32);

            for (int i = 0; i < phraseChar.Length; i++) 
            {
                if (phraseChar[i]==' ')
                {
                    phraseChar[i + 1] = (char)(phraseChar[i + 1] - 32);
                }
            }
            return phraseChar;
        }

        public static string ToTitleCase2(string phrase)
        {
            string[] phraseSplit = phrase.Split(' ');

            string b = "";
            for (int i = 0; i < phraseSplit.Length; i++) 
            {
                string a = "";

                for (int j = 0; j < phraseSplit[i].Length; j++) 
                {
                    a = a + phraseSplit[i][j];

                    if (j ==0)
                    {
                        a = a.ToUpper();
                    }
                }
                b = b + a + " ";

            }

            return b;
        }


    }
}
