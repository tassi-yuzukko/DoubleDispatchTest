using DoubleDispatchTest.BinaryTree.Acceptor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatchTest.BinaryTree.Visitor
{
    interface ITreeVisitor
    {
        void Visit(Leaf leaf);
        void Visit(Node node);
    }
}
