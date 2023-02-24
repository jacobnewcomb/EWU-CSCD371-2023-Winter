namespace Calculate.Tests
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        public void AdditionSuccess()
        {
            int res = Calculator.Add(1, 2);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void SubtractSuccess()
        {
            int res = Calculator.Subtract(8, 2);
            Assert.AreEqual(6, res);
        }
        [TestMethod]
        public void MultiplySuccess()
        {
            int res = Calculator.Multiply(4, 5);
            Assert.AreEqual(20, res);
        }
        [TestMethod]
        public void DivideSuccess()
        {
            int res = Calculator.Divide(20, 2);
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TryCalculateSuccess()
        {
            bool res = Calculator.TryCalculate("7 + 8", out int results);
            Assert.AreEqual(res, true);
            Assert.AreEqual(15, results);
        }
        [TestMethod]
        public void TryCalculateFailure()
        {
            bool res = Calculator.TryCalculate("7+8", out int result);
            Assert.AreEqual(res, false);
        }
    }
}