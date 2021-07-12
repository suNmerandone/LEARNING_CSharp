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
            public void IsMonotonicTest_1223ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 1, 2, 2, 3 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_6544ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 6, 5, 4, 4 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_132ReturnFalse()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = false;

                // act
                int[] inArray = new int[] { 1, 3, 2 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_1245ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 1, 2, 4, 5 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_111ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 1, 1, 1 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_223ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 2, 2, 3 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_221ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 2, 2, 1 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void IsMonotonicTest_9ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                int[] inArray = new int[] { 2, 2, 1 };
                var actual = LCSolution.IsMonotonic(inArray);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
