using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace LCConsoleApp.Tests
{
    public partial class LCProgramTests
    {
        public partial class LCTests
        {
            [TestMethod()]
            public void RecursionStringTest_123Return6s()
            {
                // arrange
                List<string> expectedList = new List<string> {"123", "132", "213", "231", "312", "321"};
                var expected = String.Join(", ", expectedList.ToArray());

                // act
                string inStr = "123";
                List<string> actualList = LCProgram.RecursionString("", inStr, inStr.Length);
                var actual = String.Join(", ", actualList.ToArray());

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void RecursionStringTest_223Return6s()
            {
                // arrange
                List<string> expectedList = new List<string> { "223", "232", "223", "232", "322", "322" };
                var expected = String.Join(", ", expectedList.ToArray());

                // act
                string inStr = "223";
                List<string> actualList = LCProgram.RecursionString("", inStr, inStr.Length);
                var actual = String.Join(", ", actualList.ToArray());

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void CalcDifferentIntegerCountTest_123Return6()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 6;

                // act
                int inNum = 123;
                var actual = LCSolution.CalcDifferentIntegerCount(inNum);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void CalcDifferentIntegerCountTest_223Return3()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 3;

                // act
                int inNum = 223;
                var actual = LCSolution.CalcDifferentIntegerCount(inNum);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void CalcDifferentIntegerCountTest_120Return4()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 4;

                // act
                int inNum = 120;
                var actual = LCSolution.CalcDifferentIntegerCount(inNum);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void CalcDifferentIntegerCountTest_100Return1()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 1;

                // act
                int inNum = 100;
                var actual = LCSolution.CalcDifferentIntegerCount(inNum);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
