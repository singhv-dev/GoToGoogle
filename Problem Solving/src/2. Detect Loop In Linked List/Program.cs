using System;
using System.Collections.Generic;

namespace _2._Detect_Loop_In_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<int> head = GenerateLinkedListWithoutCycle();
            bool isCycleExists = CycleDetection.IsCycleExistsWithHashMap(head);
            if (isCycleExists)
            {
                Console.WriteLine("Cycle Exists...");
            }
            else
            {
                Console.WriteLine("Cycle Does not exists...");
            }
        }

        static LinkedListNode<int> GenerateLinkedListWithoutCycle()
        {
            throw new NotImplementedException();
        }

        static LinkedListNode<int> GenerateListWithCycle()
        {
            throw new NotImplementedException();
        }
    }

    public static class CycleDetection
    {
        public static bool IsCycleExistsWithTwoPointer(LinkedListNode<int> head)
        {
            if (head == null)
                return false;

            LinkedListNode<int> firstPointer = head, secondPointer = head;
            while (firstPointer != null
                && secondPointer != null
                && secondPointer.Next != null)
            {
                firstPointer = firstPointer.Next;
                secondPointer = secondPointer.Next.Next;
                if (firstPointer == secondPointer)
                {
                    return true;
                }
            }

            return false;
        }


        public static bool IsCycleExistsWithHashMapWhenDistinctElements(LinkedListNode<int> head)
        {
            Dictionary<int, bool> nodeDictionary = new Dictionary<int, bool>();
            while (head != null)
            {
                if (nodeDictionary.ContainsKey(head.Value))
                {
                    return true;
                }

                nodeDictionary.Add(head.Value, true);
                head = head.Next;
            }

            return false;
        }

        public static bool IsCycleExistsWithHashMapWhenDuplicateElements(LinkedListNode<int> head)
        {
            Dictionary<LinkedListNode<int>, bool> nodeDictionary = new Dictionary<LinkedListNode<int>, bool>();
            while (head != null)
            {
                if (nodeDictionary.ContainsKey(head))
                {
                    return true;
                }

                nodeDictionary.Add(head, true);
                head = head.Next;
            }

            return false;
        }

        internal static bool IsCycleExistsWithHashMap(LinkedListNode<int> head)
        {
            throw new NotImplementedException();
        }
    }
}
