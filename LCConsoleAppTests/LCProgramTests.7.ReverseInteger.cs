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
            public void ReverseTest_123Return321()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 321;

                // act
                var actual = LCSolution.Reverse(123);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void ReverseTest_Neg123ReturnNeg321()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = -321;

                // act
                var actual = LCSolution.Reverse(-123);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void ReverseTest_120Return21()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 21;

                // act
                var actual = LCSolution.Reverse(120);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void ReverseTest_0Return0()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 0;

                // act
                var actual = LCSolution.Reverse(0);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
