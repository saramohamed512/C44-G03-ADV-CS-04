using System;
using static System.Collections.Specialized.BitVector32;

namespace AdvancedSession4
{
    internal class Program
    {
        #region Delegate Example03
        //public static List<int> FindOddNumbers(List<int> Numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (Numbers != null) {
        //        for (int i = 0; i < Numbers.Count; i++) {
        //            if (Numbers[i] % 2 == 1) {
        //                Result.Add(Numbers[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}
        //public static List<int> FindEvenNumbers(List<int> Numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (Numbers != null)
        //    {
        //        for (int i = 0; i < Numbers.Count; i++)
        //        {
        //            if (Numbers[i] % 2 == 0)
        //            {
        //                Result.Add(Numbers[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindNumbers(List<int> Numbers, NumberCheckFunDelegate numberCheck) {
        //    List<int> Result = new List<int>();
        //    if (Numbers != null)
        //    {
        //        for (int i = 0; i < Numbers.Count; i++)
        //        {
        //            if( numberCheck.Invoke(Numbers[i]))
        //            {
        //                Result.Add(Numbers[i]);
        //            }
        //        }
        //    }
        //    return Result;

        //}

        #endregion
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
            #region Delegate Example03
            //List<int> Numbers = new List<int>() { 1,2, 3, 4, 5 };
            //NumberCheckFunDelegate OddFunction = CheckNumbersCondition.checkOdd;
            //NumberCheckFunDelegate EvenFunction = CheckNumbersCondition.checkEven;

            //List<int> OddNumbers= FindNumbers(Numbers, OddFunction);
            //List<int> EvenNumbrs = FindNumbers(Numbers, EvenFunction);
            //foreach (int i in OddNumbers) { 
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Delegate Example03 with Generic
            //List<Double> Numbers = new List<Double>() { 1.0,2.0, 3.0, 4.0, 5.0 };
            //NumberCheckFunDelegate<Double,bool>  OddFunction = CheckNumbersCondition.checkOddDouble;
            //NumberCheckFunDelegate<Double, bool> EvenFunction = CheckNumbersCondition.checkEvenDouble;

            //List<Double> OddNumbers= FindNumbers< Double>.FindNumber(Numbers, OddFunction);
            //List<Double> EvenNumbrs = FindNumbers<Double>.FindNumber(Numbers, EvenFunction);
            //foreach (int i in OddNumbers) { 
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Built in Delegate Examples
            #region Predicate
            //Predicate<int> pred;
            //pred=new Predicate<int>(CommonFunctions.TestNumbers);
            //pred = CommonFunctions.TestNumbers;
            //Console.WriteLine(pred.Invoke(10));

            #endregion
            #region Function Delegate
            //Func<int,string> fun = CommonFunctions.Cast;
            //Console.WriteLine(fun.Invoke(42));

            #endregion
            #region Action Delegate
            //non generic action
            //Action action = CommonFunctions.Print;
            //action();
            //generic action
            //Action<String> action = CommonFunctions.Message;
            //action.Invoke("Route");
            #endregion
            #endregion
            #endregion
        }
    }
}