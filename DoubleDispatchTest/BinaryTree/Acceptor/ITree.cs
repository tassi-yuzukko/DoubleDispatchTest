using DoubleDispatchTest.BinaryTree.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatchTest.BinaryTree.Acceptor
{
    interface ITree
    {
        int Value { get; set; }
        void Accept(ITreeVisitor visitor);
    }
}
