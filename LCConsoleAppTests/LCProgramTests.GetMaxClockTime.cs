using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCConsoleApp.Tests
{
    public partial class LCProgramTests
    {
        public partial class LCTests
        {
            [TestMethod()]
            public void GetMaxClockTimeTest_1234Return2341()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "23:41";

                // act
                int inNum = 1234;
                var actual = LCSolution.GetMaxClockTime(inNum);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void GetMaxClockTimeTest_8051Return1850()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "18:50";

                // act
                int inNum = 8051;
                var actual = LCSolution.GetMaxClockTime(inNum);

                // assert
                Assert.AreEqual(expected, actual);
            }

            //[TestMethod()]
            //public void GetMaxClockTimeTest_8796Return0908()
            //{
            //    // arrange
            //    var LCSolution = new LCProgram();
            //    var expected = "09:08";

            //    // act
            //    int inNum = 8796;
            //    var actual = LCSolution.GetMaxClockTime(inNum);

            //    // assert
            //    Assert.AreEqual(expected, actual);
            //}
        }
    }
}
