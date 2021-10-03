using _6._Custom_Linked_List;
using System;
using System.Collections.Generic;

namespace _7._Palindrome_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LLNode<int> firstHead = GenerateLinkedList();
            CustomLinkedList<int>.DisplayLinkedList(firstHead);
            LLNode<int> middle = GetMiddleOfLinkedList(firstHead);
            Console.WriteLine(middle.ToString());

            LLNode<int> secondHead = middle.Next;
            middle.Next = null;

            secondHead = ReverseLinkedList(secondHead);
            bool isPalindrome = CompareLinkedLists(firstHead, secondHead);
            Console.WriteLine($"Is Linked List Palindrome: { isPalindrome }");

            secondHead = ReverseLinkedList(secondHead);
            middle.Next = secondHead;

            CustomLinkedList<int>.DisplayLinkedList(firstHead);
        }

        private static bool CompareLinkedLists(LLNode<int> firstHead, LLNode<int> secondHead)
        {
            while (!(firstHead is null) &&
                !(secondHead is null))
            {
                if (firstHead.Value != secondHead.Value)
                {
                    return false;
                }

                firstHead = firstHead.Next;
                secondHead = secondHead.Next;
            }

            return true;
        }

        private static LLNode<int> ReverseLinkedList(LLNode<int> head)
        {
            if (head is null)
                return null;

            LLNode<int> reversedHead = null;
            while (!(head is null))
            {
                LLNode<int> temp = head.Clone();
                temp.Next = reversedHead;
                reversedHead = temp;

                head = head.Next;
            }

            return reversedHead;
        }

        static LLNode<int> GetMiddleOfLinkedList(LLNode<int> head)
        {
            if (head is null)
                return null;

            LLNode<int> slow, fast;
            slow = fast = head;
            while (!(fast.Next is null) &&
                !(fast.Next.Next is null))
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        static LLNode<int> GenerateLinkedList()
        {
            List<int> items = new List<int>()
            {
                1, 3, 3, 1
            };

            LLNode<int> head = CustomLinkedList<int>.GenerateLinkedList(items);

            return head;
        }
    }
}
