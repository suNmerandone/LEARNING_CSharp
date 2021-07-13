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
            public void SortedSquares_410310Return01916100()
            {
                // arrange
                var LCSolution = new LCProgram();
                int[] outArray = new int[] { 0, 1, 9, 16, 100 };
                var expected = true;

                // act
                int[] inArray = new int[] { -4, -1, 0, 3, 10 };
                int[] actualArray = LCSolution.SortedSquares(inArray);
                var actual = System.Linq.Enumerable.SequenceEqual(outArray, actualArray);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void SortedSquares_732311Return49949121()
            {
                // arrange
                var LCSolution = new LCProgram();
                int[] outArray = new int[] { 4, 9, 9, 49, 121 };
                var expected = true;

                // act
                int[] inArray = new int[] { -7, -3, 2, 3, 11 };
                int[] actualArray = LCSolution.SortedSquares(inArray);
                var actual = System.Linq.Enumerable.SequenceEqual(outArray, actualArray);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
