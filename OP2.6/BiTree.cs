using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OPlab2._6
{
    internal class BiTree
    {
        public Node Root { get; private set; }
        
        public BiTree(char value)
        {
            Root = new Node(value);
        }
        
        public BiTree(Node node)
        {
            Root = node;
        }

        public void Insert(char value)
        {
            InsertHelper(value, Root);
        }

        public string PostorderTraverse()
        {
            return PostorderTraverseHelper(Root, new List<Node>());
        }
        public string PreorderTraverse()
        {
            return PreorderTraverseHelper(Root, new List<Node>());
        }

        public string InorderTraverse()
        {
            return InorderTraverseHelper(Root, new List<Node>());
        }

        public void FindValue(char value)
        { 
            FindValueHelper(value, Root, 0);
        }


        private void InsertHelper(char value, Node root)
        {
            if (value >= root.Value)
            {
                if (root.Right==null)
                {
                    root.Right = new Node(value);
                }
                else
                {
                    InsertHelper(value, root.Right);
                }
            }
            else
            {
                if (root.Left==null)
                {
                    root.Left = new Node(value);
                }
                else
                {
                    InsertHelper(value, root.Left);
                }
            }
        }
        private string PreorderTraverseHelper(Node root, List<Node> nodes)
        {
            nodes.Add(root);
            if (root.Left != null)
            {
                PreorderTraverseHelper(root.Left, nodes);
            }

            if (root.Right != null)
            {
                PreorderTraverseHelper(root.Right, nodes);
            }
            return string.Join(" ", nodes);
        }

        private string PostorderTraverseHelper(Node root, List<Node> nodes)
        {
            if (root.Left != null)
            {
                PostorderTraverseHelper(root.Left, nodes);
            }

            if (root.Right != null)
            {
                PostorderTraverseHelper(root.Right, nodes);
            }
            nodes.Add(root);
            return string.Join(" ", nodes);
        }

        private string InorderTraverseHelper(Node root, List<Node> nodes)
        {
            if (root.Left != null)
            {
                InorderTraverseHelper(root.Left, nodes);
            }
            nodes.Add(root);
            if (root.Right != null)
            {
                InorderTraverseHelper(root.Right, nodes);
            }
            return string.Join(" ", nodes);
        }

        private void FindValueHelper(char value, Node root, int depth)
        {
            if (value == root.Value)
            {
                Console.WriteLine($"char {value} is found, depth is {depth}");
            } 
            else if (value < root.Value)
            {
                if ( root.Left!= null)
                {
                    FindValueHelper(value, root.Left, depth + 1);
                }
            }
            else if(value > root.Value)
            {
                if ( root.Right!= null)
                {
                    FindValueHelper(value, root.Right, depth + 1);
                }
            }
        }
    }
}