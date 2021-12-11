using System;
using System.Collections.Generic;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        /*
         * Write a function to delete a node in a singly-linked list. 
         * You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
         * It is guaranteed that the node to be deleted is not a tail node in the list.
         */

        public class ListNode_TIQ_DelNode
        {
            public int val;
            public ListNode_TIQ_DelNode next;
            public ListNode_TIQ_DelNode(int x)
            {
                val = x;
                //next = null;
            }
        }

        public void DeleteNode(ListNode_TIQ_DelNode node)
        {
            ListNode_TIQ_DelNode currentNode = node;
            ListNode_TIQ_DelNode nextNode = node.next;

            currentNode.val = nextNode.val;
            currentNode.next = nextNode.next;
        }
    }
}
