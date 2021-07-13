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
            public void SortStringTest_aaaabbbbccccReturnabccbaabccba()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "abccbaabccba";

                // act
                string input = "aaaabbbbcccc";
                var actual = LCSolution.SortString(input);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void SortStringTest_ratReturnart()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "art";

                // act
                string input = "rat";
                var actual = LCSolution.SortString(input);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void SortStringTest_leetcodeReturncdelotee()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "cdelotee";

                // act
                string input = "leetcode";
                var actual = LCSolution.SortString(input);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void SortStringTest_gggggggReturnggggggg()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "ggggggg";

                // act
                string input = "ggggggg";
                var actual = LCSolution.SortString(input);

                // assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod()]
            public void SortStringTest_spoReturnops()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = "ops";

                // act
                string input = "spo";
                var actual = LCSolution.SortString(input);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
