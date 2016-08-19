using System;
namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.
        public static void Main()
        {
            Console.WriteLine("Please input the string1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please input the stirng2:");
            string s2 = Console.ReadLine();
            Console.WriteLine(FindWord(s1, s2));
              
        }
        public static int FindWord(string s1, string s2)
        {
            //YOUR CODE HERE

            s1 = s1.ToLower();
            s2 = s2.ToLower();

            if (s1.Length < s2.Length) 
            {
                string term = s1;
                s1 = s2;
                s2 = term;
            }
            int result = -1;

            for (int i = 0; i < s1.Length + 1 - s2.Length; i++) 
            {
                if (s1.Substring(i, s2.Length) == s2) 
                {
                    result = i+1;
                    break;
                }
            }
            return result;

        }
    }
}
