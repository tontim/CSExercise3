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
            return input.Length >= 2 && input.Length <= 10;
        }
        public static bool StringWithin3and15(string input)
        {
            return input.Length >= 3 && input.Length <= 15;
        }
    }
}
