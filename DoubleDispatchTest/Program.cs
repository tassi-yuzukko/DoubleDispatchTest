using DoubleDispatchTest.BinaryTree.Acceptor;
using DoubleDispatchTest.BinaryTree.Visitor;
using DoubleDispatchTest.ユーザ情報;
using DoubleDispatchTest.利用者特定;
using System;

namespace DoubleDispatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //JikiCardInfo jikiCardInfo = new JikiCardInfo();

            //new IdentifyUserByJikiCard().IdentifyUser(jikiCardInfo);

            MakeTree();

            Console.ReadKey();
        }

        static void MakeTree()
        {
            ITree leaf1 = new Leaf(1);
            ITree leaf2 = new Leaf(2);
            ITree leaf3 = new Leaf(3);
            ITree leaf4 = new Leaf(4);
            ITree node1 = new Node(5, leaf1, leaf2);
            ITree node2 = new Node(6, leaf3, leaf4);
            ITree nodeTop = new Node(7, node1, node2);

            //ITreeVisitor visitor = new TreeVisitor();
            //nodeTop.Accept(visitor);
            nodeTop.Execute();
        }
    }
}
