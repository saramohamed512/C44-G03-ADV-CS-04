using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class Helper<T>
    {
        public static void swap(ref T a , ref T b)
        {
            T tem = a;
            a= b;
            b= tem;
        }

        public static void BubbleSort(T[] array, SotingTypesFunctionDelegate<T,bool> sortingTypesDel) {
            if (array is not null) {
                for (int i = 0; i < array.Length; i++) {
                    for (int j = 0; j < array.Length-1-i; j++) { 
                      if(sortingTypesDel.Invoke(array[j], array[j + 1])){
                            swap(ref array[j], ref array[j + 1]);
                        }
                          
                        
                    }
                }
            }
        }

    }
}
