using System;
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

        [TestMethod]
        public void NodeExistTestTrue()
        {
            var node = new Node(10);
            node.Append(20);
            var res = node.Exists(20);
            Assert.IsTrue(res);
        }
    }
}