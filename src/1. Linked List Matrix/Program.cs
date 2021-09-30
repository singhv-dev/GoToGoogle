using System;
using System.Collections.Generic;

namespace _1._Linked_List_Matrix
{
    class Node
    {
        public int? data;
        public Node right;
        public Node down;

        public Node(int? val, Node rightNode = null, Node downNode = null)
        {
            this.data = val;
            this.right = rightNode;
            this.down = downNode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int matrixLen = 1;
            List<int> matrixData = new List<int>()
            {
                1
            };

            int[,] matrix = new int[3, 3]
            {
                {
                    1, 2, 3
                },
                {
                    4, 5, 6
                },
                {
                    7, 8, 9
                }
            };

            //Node head = ConstructLinkedMatrix(matrixData, matrixLen);
            Node head = ConstructLinkedMatrixWithRecursion(matrix, 0, 0, 3, 3);
            Display(head);
        }

        private static void Display(Node head)
        {
            Node temp = null;
            while (head != null)
            {
                temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data);
                    Console.Write(" ");
                    temp = temp.right;
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                head = head.down;
            }
        }

        private static Node ConstructLinkedMatrixWithRecursion(int[,] matrix, int currRow, int currCol, int rowSize, int colSize)
        {
            if (currRow >= rowSize ||
                currCol >= colSize)
            {
                return null;
            }

            Node node = new Node(matrix[currRow, currCol]);
            node.right = ConstructLinkedMatrixWithRecursion(matrix, currRow, currCol + 1, rowSize, colSize);
            node.down = ConstructLinkedMatrixWithRecursion(matrix, currRow + 1, currCol, rowSize, colSize);

            return node;
        }


        private static Node ConstructLinkedMatrix(List<int> matrixData, int matrixLen)
        {
            Node[,] linkedMatrix = new Node[30, 30];
            for (int i = matrixLen; i >= 0; i--)
            {
                for (int j = matrixLen; j >= 0; j--)
                {
                    if (i == matrixLen &&
                        j == matrixLen)
                    {
                        continue;
                    }
                    else if (i == matrixLen ||
                        j == matrixLen)
                    {
                        linkedMatrix[i, j] = null;
                    }
                    else
                    {
                        linkedMatrix[i, j] = new Node(matrixData[matrixLen * i + j]);
                        linkedMatrix[i, j].right = linkedMatrix[i, j + 1];
                        linkedMatrix[i, j].down = linkedMatrix[i + 1, j];
                    }
                }
            }

            return linkedMatrix[0, 0];
        }
    }
}
