using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3
{
    internal class Utility
    {
        public static bool IsGreaterThanZero(int number)
        {
            return number > 0;
        }
        public static bool StringWithin2and10(string input)
        { 
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("No fname input.");
            }
            else 
            { 
                return input.Length >= 2 && input.Length <= 10;
            }
        }
        public static bool StringWithin3and15(string input)
        {
            return input.Length >= 3 && input.Length <= 15;
        }
        //Bra sätt kolla om en bool är inom gränserna!
        public static bool IsWithinRange(double number, double min, double max)
        {
            return number >= min && number <= max;
        }
       
    }
}
