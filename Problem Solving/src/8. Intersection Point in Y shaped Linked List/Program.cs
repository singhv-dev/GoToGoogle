using _6._Custom_Linked_List;
using System;

namespace _8._Intersection_Point_in_Y_shaped_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public int intersectPoint(LLNode<int> first, LLNode<int> second)
        {
            int firstLength = GetLinkedListLength(first);
            int secondLength = GetLinkedListLength(second);
            if (firstLength > secondLength)
            {
                first = MoveKPointerAhead(first, firstLength - secondLength);
            }
            else if (secondLength > firstLength)
            {
                second = MoveKPointerAhead(second, secondLength - firstLength);
            }

            while (first != null && second != null)
            {
                if (first.Value == second.Value)
                {
                    return first.Value;
                }

                first = first.Next;
                second = second.Next;
            }

            return -1;
        }

        public static LLNode<int> MoveKPointerAhead(LLNode<int> head, int k)
        {
            while (k > 0 && head != null)
            {
                head = head.Next;
                k--;
            }

            return head;
        }

        public static int GetLinkedListLength(LLNode<int> head)
        {
            int cnt = 0;
            while (head != null)
            {
                cnt++;
                head = head.Next;
            }

            return cnt;
        }
    }
}
