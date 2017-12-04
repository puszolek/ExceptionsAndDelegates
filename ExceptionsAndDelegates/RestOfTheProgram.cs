using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionsAndDelegates.Form1;

namespace ExceptionsAndDelegates
{
    class RestOfTheProgram
    {
        public static void ShowResult(Action<string> result, string t)
        {
            string result0 = "Result: 0";
            result(t);
        }

        public static void FunctionWith1Param(Func<double, double> operation1, double x)
        {
            RestOfTheProgram.ShowResult(operation1(x));
        }

        public static void FunctionWith2Params(Func<double, double, double> operation2, double x, double y)
        {
            operation2(x, y);
        }
    }
}
