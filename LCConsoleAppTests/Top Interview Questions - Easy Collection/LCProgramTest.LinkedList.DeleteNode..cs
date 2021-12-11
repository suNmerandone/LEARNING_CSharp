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
            public void DeleteNodeTest_4519Del5Return419True()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                LCProgram.ListNode_TIQ_DelNode node_0 = new LCProgram.ListNode_TIQ_DelNode(4);
                LCProgram.ListNode_TIQ_DelNode node_1 = new LCProgram.ListNode_TIQ_DelNode(5);
                LCProgram.ListNode_TIQ_DelNode node_2 = new LCProgram.ListNode_TIQ_DelNode(1);
                LCProgram.ListNode_TIQ_DelNode node_3 = new LCProgram.ListNode_TIQ_DelNode(9);

                node_0.next = node_1;
                node_1.next = node_2;
                node_2.next = node_3;
                node_3.next = null;

                LCSolution.DeleteNode(node_1);

                string strAfter = string.Empty;
                var curNode = node_0;
                while (curNode.next != null)
                {
                    strAfter += curNode.val.ToString();
                    curNode = curNode.next;
                }
                strAfter += curNode.val.ToString();         // Last node

                bool actual = false;
                if (strAfter.CompareTo("419") == 0)
                {
                    actual = true;
                }

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void DeleteNodeTest_4519Del1Return459True()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                LCProgram.ListNode_TIQ_DelNode node_0 = new LCProgram.ListNode_TIQ_DelNode(4);
                LCProgram.ListNode_TIQ_DelNode node_1 = new LCProgram.ListNode_TIQ_DelNode(5);
                LCProgram.ListNode_TIQ_DelNode node_2 = new LCProgram.ListNode_TIQ_DelNode(1);
                LCProgram.ListNode_TIQ_DelNode node_3 = new LCProgram.ListNode_TIQ_DelNode(9);

                node_0.next = node_1;
                node_1.next = node_2;
                node_2.next = node_3;
                node_3.next = null;

                LCSolution.DeleteNode(node_2);

                string strAfter = string.Empty;
                var curNode = node_0;
                while (curNode.next != null)
                {
                    strAfter += curNode.val.ToString();
                    curNode = curNode.next;
                }
                strAfter += curNode.val.ToString();         // Last node

                bool actual = false;
                if (strAfter.CompareTo("459") == 0)
                {
                    actual = true;
                }

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void DeleteNodeTest_neg3599DelNeg3ReturnNeg599True()
            {
                // arrange
                var LCSolution = new LCProgram();
                var expected = true;

                // act
                LCProgram.ListNode_TIQ_DelNode node_0 = new LCProgram.ListNode_TIQ_DelNode(-3);
                LCProgram.ListNode_TIQ_DelNode node_1 = new LCProgram.ListNode_TIQ_DelNode(5);
                LCProgram.ListNode_TIQ_DelNode node_2 = new LCProgram.ListNode_TIQ_DelNode(-99);

                node_0.next = node_1;
                node_1.next = node_2;
                node_2.next = null;

                LCSolution.DeleteNode(node_0);

                string strAfter = string.Empty;
                var curNode = node_0;
                while (curNode.next != null)
                {
                    strAfter += curNode.val.ToString();
                    curNode = curNode.next;
                }
                strAfter += curNode.val.ToString();         // Last node

                bool actual = false;
                if (strAfter.CompareTo("5-99") == 0)
                {
                    actual = true;
                }

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
