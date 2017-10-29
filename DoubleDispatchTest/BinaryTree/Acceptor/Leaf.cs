using DoubleDispatchTest.BinaryTree.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatchTest.BinaryTree.Acceptor
{
    class Leaf : ITree
    {
        public int Value { get; set; }

        public Leaf(int value)
        {
            Value = value;
        }

        public void Accept(ITreeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
