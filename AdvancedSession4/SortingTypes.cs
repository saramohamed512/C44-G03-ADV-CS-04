using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    public delegate bool SotingTypesFunctionDelegate(int x, int y);
    internal class SortingTypes
    {
        public static bool CompareGraterThan(int x ,int y)
        {
            return x > y;
        }
        public static bool CompareLessThan(int x, int y)
        {
            return x <  y;
        }
    }
}
