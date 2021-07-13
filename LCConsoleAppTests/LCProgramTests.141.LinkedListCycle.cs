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
            public void HasCycleTest_320neg4pos1ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                LCProgram.ListNode_141 node_0 = new LCProgram.ListNode_141(3);
                LCProgram.ListNode_141 node_1 = new LCProgram.ListNode_141(2);
                LCProgram.ListNode_141 node_2 = new LCProgram.ListNode_141(0);
                LCProgram.ListNode_141 node_3 = new LCProgram.ListNode_141(-4);

                node_0.next = node_1;
                node_1.next = node_2;
                node_2.next = node_3;
                node_3.next = node_1;

                var actual = LCSolution.HasCycle(node_0);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void HasCycleTest_12pos0ReturnTrue()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                LCProgram.ListNode_141 node_0 = new LCProgram.ListNode_141(1);
                LCProgram.ListNode_141 node_1 = new LCProgram.ListNode_141(2);

                node_0.next = node_1;
                node_1.next = node_0;

                var actual = LCSolution.HasCycle(node_0);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void HasCycleTest_1posNeg1ReturnFalse()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = false;

                // act
                LCProgram.ListNode_141 node_0 = new LCProgram.ListNode_141(1);

                node_0.next = null;

                var actual = LCSolution.HasCycle(node_0);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void HasCycleTest_123posNeg1ReturnFalse()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = false;

                // act
                LCProgram.ListNode_141 node_0 = new LCProgram.ListNode_141(1);
                LCProgram.ListNode_141 node_1 = new LCProgram.ListNode_141(2);
                LCProgram.ListNode_141 node_2 = new LCProgram.ListNode_141(3);

                node_0.next = node_1;
                node_1.next = node_2;
                node_2.next = null;

                var actual = LCSolution.HasCycle(node_0);

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void HasCycleTest_1233posNeg1ReturnFalse()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = false;

                // act
                LCProgram.ListNode_141 node_0 = new LCProgram.ListNode_141(1);
                LCProgram.ListNode_141 node_1 = new LCProgram.ListNode_141(2);
                LCProgram.ListNode_141 node_2 = new LCProgram.ListNode_141(3);
                LCProgram.ListNode_141 node_3 = new LCProgram.ListNode_141(3);

                node_0.next = node_1;
                node_1.next = node_2;
                node_2.next = node_3;
                node_3.next = null;

                var actual = LCSolution.HasCycle(node_0);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
