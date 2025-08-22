using System;

namespace AdvancedSession4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate 
            #region Delegate Example01
            ////int x;
            ////x=5;
            ////x=6;
            ////step01 Declare refrence from delegate
            //StringFunctionDelegate reference;
            ////step02 intialize reference to function 
            ////reference = new StringFunctionDelegate(StringFunction.CountOfUpperCase);
            //reference = StringFunction.CountOfUpperCase;// Syntax Sugar
            ////reference += StringFunction.CountOfLowerCase;//add method to delegate
            ////reference -= StringFunction.CountOfLowerCase;//remove method to delegate
            ////step03 use delegate
            //int Result = reference.Invoke("SarA");
            //Console.WriteLine(Result);


            #endregion
            #region Delegate Example02
            //Bubble sort Algo
            //int[] Numbers = { 8, 6, 7, 8, 9, 10 };
            //Helper.BubbleSort(Numbers, SortingTypes.CompareGraterThan);
            //Helper.BubbleSort(Numbers, SortingTypes.CompareLessThan);
            //foreach (int i in Numbers) { 
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Delegate Example02 with Generic
            //string[] Names = { "Mohamed", "Sara", "Ali", "Menna", "Aya" };
            //SotingTypesFunctionDelegate<string, bool> sortStringAsc = SortingTypes.sortStrAsc;
            //Helper<string>.BubbleSort(Names, SortingTypes.sortStrAsc);
            //foreach (string name in Names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #endregion
        }
    }
}