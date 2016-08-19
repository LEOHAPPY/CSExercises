using System;
namespace CSExercises
{
    //Write a static method:  Substitute(string s, char c1, char c2) that would 
    //return a string. The method should find all occurrences of the character c1 
    //in the string s and substitute c1 with character c2.  The new word so formed would 
    //be the return value of this method. 
    public class ExH4
    {
        public static void Main()
        {
            Console.WriteLine("Please input a phrase \'s\'");
            string s = Console.ReadLine();
            Console.WriteLine("Please input \'c1\'");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please input \'c2\'");
            char c2 = Convert.ToChar(Console.ReadLine());

            char[] resule = Substitute(s,c1,c2);
            for (int i = 0; i < resule.Length; i++)
            {
                Console.Write(resule[i]);
            }
            Console.WriteLine();
        }
        public static char[] Substitute(string s, char c1, char c2)
        {
            //YOUR CODE HERE
            char[] ss = s.ToCharArray(); //string change to charArray!

            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == c1) 
                {
                    ss[i] = c2;
                }
            }

            //result = ss.ToString();
           
            return ss;
        }
    }
}
