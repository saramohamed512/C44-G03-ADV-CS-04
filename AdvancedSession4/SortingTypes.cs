using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    public delegate bool SotingTypesFunctionDelegate(int x, int y);
    public delegate TResult SotingTypesFunctionDelegate<in T,out TResult>(T x, T y);
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

        public static bool sortStrAsc(string x, string y) { 
            return x.Length > y.Length;
        }
        public static bool sortStrDesc(string x, string y)
        {
            return x.Length < y.Length;
        }
    }
}
