using System;
using System.Xml.Linq;
using GenericsHomework;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void NodeAppendTest()
        {
            var node = new Node(10);
            node.Append(20);
            Assert.IsTrue(node.Exists(20));
        }

        private int CountNodes(Node node)
        {
            int count = 1;
            var curr = node.Next;
            while (curr != node)
            {
                count++;
                curr = curr.Next;
            }
            return count;
        }

        [TestMethod]
        public void NodeClearTest()
        {
            var node = new Node(10);
            node.Append(20);
            node.Append(30);
            node.Clear();
            Assert.AreEqual(1, CountNodes(node));
        }

        [TestMethod]
        public void NodeExistTestTrue()
        {
            var node = new Node(10);
            node.Append(20);
            var res = node.Exists(20);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void NodeExistTestFalse()
        {
            var node = new Node(10);
            node.Append(20);
            var res = node.Exists(20);
            Assert.IsFalse(res);
        }
    }
}