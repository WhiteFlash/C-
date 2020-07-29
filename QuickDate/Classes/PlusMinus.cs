using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDate.Classes
{
    /// <summary>
    /// Program counts quantity of numbers that meets in the array.
    /// Output result is probability of negative, positive and zeros in the array.
    /// </summary>
    public class PlusMinus
    {
        /// <summary>
        /// Function to execute in Main function. 
        /// This will fire the program.
        /// </summary>
        public static void ExecuteProgram()
        {
            int[] mat = { -4, 3, -9, 0, 4, 1 };
            plusMinus(mat);
        }
        /// <summary>
        /// Function counts how many positive, negative and zeros numbers in array.
        /// Then it devides each quantity on total elements in the array.
        /// </summary>
        /// <param name="arr">Array of different numbers has to be passed to the function.</param>
        public static string[] plusMinus (int[] arr) 
        {
            int[] count = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count[0]++;
                }
                else if (arr[i] == 0)
                {
                    count[1]++;
                }
                else
                {
                    count[2]++;
                }
            }
            double pos = count[0];
            double quantity = arr.Length;
            string positiveNumbersInArray = Math.Round(Math.Abs(pos / quantity), 6).ToString();
            double zero = count[1];
            string zeroNumbersInArray = Math.Round(Math.Abs(zero / quantity), 6).ToString();
            double neg = count[2];
            string negativeNumbersInArray = Math.Round(Math.Abs(neg / quantity), 6).ToString();
            //double matrix = { pos, zero, neg };
            //return matrix;
            string[] count2 = new string[3];
            count2[0] = negativeNumbersInArray;
            count2[1] = zeroNumbersInArray;
            count2[2] = positiveNumbersInArray;
            foreach (var m in count2)
            {
                Console.WriteLine(m);
            }
            return count2;
        }
    }
}
