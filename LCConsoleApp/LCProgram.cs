using System;
using System.Collections.Generic;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //List<string> expected = new List<string> { "123", "132", "213", "231", "312", "321" };
            //var result = String.Join(", ", expected.ToArray());
            //Console.WriteLine(result);

            LCProgram myLC = new LCProgram();
            //myLC.CalcDifferentIntegerCount(120);
            myLC.GetMaxClockTime(1234);
        }
    }
}
