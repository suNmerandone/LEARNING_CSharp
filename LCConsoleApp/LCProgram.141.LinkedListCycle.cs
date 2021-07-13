using System;
using System.Collections.Generic;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        /*
         * Given head, the head of a linked list, determine if the linked list has a cycle in it.
         * There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
         * Return true if there is a cycle in the linked list. Otherwise, return false.
         */

        public class ListNode_141
        {
            public int val;
            public ListNode_141 next;
            public ListNode_141(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool HasCycle(ListNode_141 head)
        {
            // To judge the pos is less than the length of ListNode
            bool hasCycle = false;

            List<ListNode_141> allNodeList = new List<ListNode_141>();
            ListNode_141 currentNode = head;
            while (currentNode != null && currentNode.next != null)
            {
                ListNode_141 nextNode = currentNode.next;
                int pos = allNodeList.FindIndex(x => x.Equals(nextNode));
                if (pos > -1)
                {
                    hasCycle = true;
                    break;
                }

                allNodeList.Add(currentNode);
                currentNode = currentNode.next;
            }

            return hasCycle;
        }

        /*
         * Floyd's Cycle Finding Algorithm (https://zh.wikipedia.org/wiki/Floyd%E5%88%A4%E5%9C%88%E7%AE%97%E6%B3%95)
         * 龜兔賽跑算法 - 如果有限狀態機、疊代函數或者鍊表上存在環，那麼在某個環上以不同速度前進的2個指針必定會在某個時刻相遇。
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }
         */
    }
}
