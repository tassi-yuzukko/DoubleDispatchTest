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
            Leaf leaf1 = new Leaf(1);
            Leaf leaf2 = new Leaf(2);
            Leaf leaf3 = new Leaf(3);
            Leaf leaf4 = new Leaf(4);
            Node node1 = new Node(5, leaf1, leaf2);
            Node node2 = new Node(6, leaf3, leaf4);
            Node nodeTop = new Node(7, node1, node2);

            ITreeVisitor visitor = new TreeVisitor();
            nodeTop.Accept(visitor);
        }
    }
}
