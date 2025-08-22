using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class FindNumbers<T>
    {
        public static List<T> FindNumber(List<T> Numbers, NumberCheckFunDelegate<T, bool> numberCheck)
        {
            List<T> Result = new List<T>();
            if (Numbers != null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    if (numberCheck.Invoke(Numbers[i]))
                    {
                        Result.Add(Numbers[i]);
                    }
                }
            }
            return Result;

        }
    }
}
