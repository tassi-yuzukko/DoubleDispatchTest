using System;
using System.Collections.Generic;
using System.Text;
using DoubleDispatchTest.BinaryTree.Acceptor;

namespace DoubleDispatchTest.BinaryTree.Visitor
{
    class TreeVisitor : ITreeVisitor
    {
        public void Visit(Leaf leaf)
        {
            Console.WriteLine($"Leaf : {leaf.Value}");
        }

        public void Visit(Node node)
        {
            Console.WriteLine($"Node : {node.Value}");
        }
    }
}
