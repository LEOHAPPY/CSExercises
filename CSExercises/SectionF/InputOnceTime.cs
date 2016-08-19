using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.SectionF
{
    class InputOnceTime
    {
        public static void Main()
        {
            Console.WriteLine("Please input all the number once using tab as a gap");
             //Console.WriteLine("Jan.\tFab.\tMar.\tApr.\tMa.\tJun.\tJul.\tAug.\tSep.\tOct.\tNev.\tDec");
            string inputOnce = Console.ReadLine();

            int[] splitInputInt = SplitInputInt(inputOnce);

            for (int i =0; i<splitInputInt.Length;i++)
            {
                Console.WriteLine(splitInputInt[i]);
            }

        }

        public static int[] SplitInputInt(string inputOnce)
        {
            string[] splitInput = inputOnce.Split('\t');
            int[] splitInputInt = new int[splitInput.Length];
            for (int i = 0; i<splitInput.Length; i++)
            {
                splitInputInt[i] = Convert.ToInt32(splitInput[i]);
            }
            return splitInputInt;
        }

    }
}
