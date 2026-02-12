using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    public delegate int StringFunctionDelegate(string str);
    internal class StringFunction
    {
        public static int CountOfUpperCase(string name)
        {
            int count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i])) count++;
                }
            }
            return count;
        }
        public static int CountOfLowerCase(string name)
        {
            int count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLower(name[i])) count++;
                }
            }
            return count;
        }
    }
}
