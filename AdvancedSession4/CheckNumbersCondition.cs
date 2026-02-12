using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    public delegate TResult NumberCheckFunDelegate<in T, out TResult>(T item);
    internal class CheckNumbersCondition
    {
        public static bool checkOdd(int Number) { 
           return (Number % 2 == 1);
        }
        public static bool checkEven(int Number)
        {
            return (Number % 2 == 0);
        }
        public static bool checkOddDouble(Double Number)
        {
            return (Number % 2 == 1);
        }
        public static bool checkEvenDouble(Double Number)
        {
            return (Number % 2 == 0);
        }
    }
}
