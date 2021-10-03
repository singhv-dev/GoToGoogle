using _6._Custom_Linked_List;
using System;
using System.Collections.Generic;

namespace _9._Reverse_a_Linked_List_in_Group_of_Given_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = GenerateLinkedList();
            CustomLinkedList<int>.DisplayLinkedList(head);
            head = ReverseLinkedListWithChunks(head, 2);
            CustomLinkedList<int>.DisplayLinkedList(head);
        }

        static LLNode<int> ReverseLinkedListWithChunks(LLNode<int> head, int k)
        {
            if (head == null)
                return null;

            LLNode<int> spanFirst, spanLast, reversedFirst, reversedLast;
            spanFirst = spanLast = reversedFirst = reversedLast = null;
            int cnt = 0;
            while (head != null)
            {
                LLNode<int> temp = head;
                head = head.Next;
                temp.Next = null;

                if (spanFirst is null)
                {
                    spanFirst = spanLast = temp;
                }
                else
                {
                    temp.Next = spanFirst;
                    spanFirst = temp;
                }

                cnt++;

                if (cnt == k)
                {
                    if (reversedFirst is null)
                    {
                        reversedFirst = spanFirst;
                        reversedLast = spanLast;
                    }
                    else
                    {
                        reversedLast.Next = spanFirst;
                        reversedLast = spanLast;
                    }

                    spanFirst = spanLast = null;

                    cnt = 0;
                }
            }

            if (spanFirst != null)
            {
                if (reversedFirst is null)
                {
                    reversedFirst = spanFirst;
                    reversedLast = spanLast;
                }
                else
                {
                    reversedLast.Next = spanFirst;
                    reversedLast = spanLast;
                }

                spanFirst = spanLast = null;
            }

            return reversedFirst;
        }

        static LLNode<int> GenerateLinkedList()
        {
            List<int> items = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            LLNode<int> head = CustomLinkedList<int>.GenerateLinkedList(items);

            return head;
        }
    }
}
