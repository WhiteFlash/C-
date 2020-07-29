using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuickDate.Classes
{
    /// <summary>
    /// Sherlock considers a string to be valid if all characters of the string appear the same number of times. 
    /// It is also valid if he can remove just 1 character at index 1 in the string, and the remaining characters will occur the same number of times. 
    /// Given a string, determine if it is valid.If so, return YES, otherwise return NO.
    ///For example, if it is a valid string because frequencies are.
    ///So is because we can remove one and have of each character in the remaining string. 
    ///If however, the string is not valid as we can only remove occurrence of . That would leave character frequencies of . 
    /// </summary>
    class Sherlock_and_the_Valid_String
    {
        public static void Maining()
        {
           string text = "aabbcd";
           List<Frequencie> frequencies = CountFrequencie(text);

           foreach (var x in frequencies)
           {
               Console.WriteLine($"Буква - {x.Letter} --- Встречается - {x.Quantity} раз");
           }

            var isValid = IsValid(frequencies);
            if (isValid)
            {
                Console.WriteLine("Строка is valid");
            }
            else
            {
                Console.WriteLine("Строка is not valid");
            }

        }

        /// <summary>
        /// Count letters in string. How often it appears in the string.
        /// </summary>
        /// <param name="text"> String to count letters and their frequency in the string. </param>
        /// <returns></returns>
        public static List<Frequencie> CountFrequencie(string text)
        {
            List<Frequencie> frequencies = new List<Frequencie>();

            Frequencie letter = new Frequencie();
            letter.Letter = text[0];
            var count = 'a';
            while ((int)count <= 122)
            {
                for (var i = 0; i <= text.Length - 1; i++)
                {
                    if (text[i] == count)
                    {
                        letter.Quantity++;
                    }
                }
                if (letter.Quantity > 0)
                {
                    frequencies.Add(letter);
                }
                count++;
                letter = new Frequencie();
                letter.Letter = (char)count;
            }
            return frequencies;
        }
    
        public static bool IsValid(List<Frequencie> frequencies)        
        {
            bool[] has_been_check_of_frequencie_in_list = new bool[2];
            var x = frequencies.FirstOrDefault();
            var count = 0;
            foreach (var m in frequencies)
            {
                if(m.Quantity != x.Quantity)
                {
                    var ostatok = m.Quantity - 1;
                    if((Math.Abs(m.Quantity - x.Quantity)) == 1 && (ostatok == x.Quantity) || ostatok == 0)
                    {
                        has_been_check_of_frequencie_in_list[count] = true;
                        count++;
                    }
                    else
                    {
                        return false;
                    }
                }                
            }
            if(has_been_check_of_frequencie_in_list.Length == 1)
            {
                return false;
            }
            return true;
        }
    }

    class Frequencie
    {
        public char Letter { get; set; }
        public int Quantity { get; set; } = 0;
    }
}
