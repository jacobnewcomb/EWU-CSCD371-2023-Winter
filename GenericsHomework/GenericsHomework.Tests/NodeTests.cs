using System;
using System.Xml.Linq;
using GenericsHomework;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void NodeIsNotNull()
        {
            Node node = new Node(10);
            Assert.IsNotNull(node);
        }

        [TestMethod]
        public void NodeAppendTest()
        {
            var node = new Node(10);
            node.Append(20);
            Assert.IsTrue(node.Exists(20));
        }


        [TestMethod]
        public void NodeClearTest()
        {
            var node = new Node(10);
            node.Append(20);
            node.Append(30);
            node.Clear();
            Assert.AreEqual(1, node.CountNodes());
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