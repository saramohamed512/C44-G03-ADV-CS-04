using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class CommonFunctions
    {
        #region Predicate
        //public static bool TestNumbers(int Number)
        //{
        //    return Number > 0;
        //}

        #endregion
        #region Function Delegate
        public static string Cast(int Number) { 
        return Number.ToString();
        }
        #endregion
        #region Action Delegate
        //non generic action
        public static void Print() {
            Console.WriteLine("Helo From non generic action ");
        }
        //generic action
        public static void Message(string msg)
        {
            Console.WriteLine($"Helo From  generic action {msg}");
        }
        #endregion
    }
}
