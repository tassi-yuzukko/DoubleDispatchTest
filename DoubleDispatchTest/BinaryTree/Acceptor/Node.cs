using System;
using System.Collections.Generic;
using System.Text;
using DoubleDispatchTest.BinaryTree.Visitor;

namespace DoubleDispatchTest.BinaryTree.Acceptor
{
    class Node : ITree
    {
        public int Value { get; set; }
        ITree left;
        ITree right;

        public Node(int value, ITree left, ITree right)
        {
            Value = value;
            this.left = left;
            this.right = right;
        }

        public void Accept(ITreeVisitor visitor)
        {
            left.Accept(visitor);
            visitor.Visit(this);
            right.Accept(visitor);
        }
    }
}
