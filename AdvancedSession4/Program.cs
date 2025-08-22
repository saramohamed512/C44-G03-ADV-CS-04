using System;

namespace AdvancedSession4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate 
            #region Delegate Example01
            //int x;
            //x=5;
            //x=6;
            //step01 Declare refrence from delegate
            StringFunctionDelegate reference;
            //step02 intialize reference to function 
            //reference = new StringFunctionDelegate(StringFunction.CountOfUpperCase);
            reference = StringFunction.CountOfUpperCase;// Syntax Sugar
            //reference += StringFunction.CountOfLowerCase;//add method to delegate
            //reference -= StringFunction.CountOfLowerCase;//remove method to delegate
            //step03 use delegate
            int Result = reference.Invoke("SarA");
            Console.WriteLine(Result);


            #endregion

            #endregion
        }
    }
}