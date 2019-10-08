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
            public void MincostTicketsTest_Return11()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 11;

                // act
                int[] days = new int[6] { 1, 4, 6, 7, 8, 20 };
                int[] costs = new int[3] { 2, 7, 15 };
                var actual = LCSolution.MincostTickets(days, costs);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void MincostTicketsTest_Return17()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 17;

                // act
                int[] days = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
                int[] costs = new int[3] { 2, 7, 15 };
                var actual = LCSolution.MincostTickets(days, costs);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void MincostTicketsTest_Return6()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = 6;

                // act
                int[] days = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
                int[] costs = new int[3] { 7, 2, 15 };
                var actual = LCSolution.MincostTickets(days, costs);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
