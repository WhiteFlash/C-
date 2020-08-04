using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDate.Classes
{
    public class EfficientJanitor
    {
        /*
            Neccessary for the end when comparing numbers.
        */
        public static bool CompareDigits(float x, float y)
        {
            if (x + y <= 3.0)
            {
                return true;
            }
            return false;
        }

        /*
            Tells how much more to carry if the number has been selected from array.
        */
        public static float HowMuchLeft(float x) => 3 - x;


        /*
            Looking for the numbers that will have 3.0 in total.
            Returns all posible numbers that left from array the will be less then 
            3.0. Sum of selected number + the second number in array has to be less or equal to 3.0.
            Function will return all the numbers that suits conditions.
        */
        public static float[] Search(float[] numbers, float leftOver)
        {
            float[] comparingArray = new float[numbers.Length];
            var countForComparingArray = 0;

            for (var i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] <= leftOver)
                {
                    comparingArray[countForComparingArray] = numbers[i];
                    countForComparingArray++;
                }
            }
            var test = from t in comparingArray
                           where t > 0
                           select t;

            return test.ToArray();
        }


        /// <summary>
        /// Change the way numbers can be selected from array.
        /// Use linq or lambda expression.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="selectedNumber"></param>
        /// <returns></returns>
        //public static float[] Search2 (float[] numbers, float leftOver)
        //{
        //    return numbers.Where(x => x <= leftOver);
        //}

        /*
            Function chooses highest second number. The sum will be closer to 3.0. 
            the MaxNumberInArray is the second number. 
        */
        public static float[] BestOption(float[] numbers, float selectedNumber)
        {
            float maxSumm = 0f;
            float maxNumberInArray = 0f;
            for (var i = 0; i <= numbers.Length - 1; i++)
            {
                if (maxSumm < (selectedNumber + numbers[i]))
                {
                    maxSumm = selectedNumber + numbers[i];
                    maxNumberInArray = numbers[i];
                }
            }
            float[] returningArray = new float[] { maxSumm, maxNumberInArray };
            return returningArray;
        }

        public static int EfficientJanitorMainMethod(List<float> weight)
        {
            var trips = 0;
            float[] weightArray = weight.ToArray();
            float number;
            float[] searchArray = new float[weightArray.Length];
            float[] bestOptionInArray = new float[weightArray.Length];
            float leftOver = 0.0f;

            for (int i = 0; i <= weightArray.Length - 1; i++)
            {
                number = weightArray[i];
                leftOver = HowMuchLeft(number);
                searchArray = Search(weightArray, leftOver);
                bestOptionInArray = BestOption(searchArray, number);

            }

            return trips;
        }

        }
    }
