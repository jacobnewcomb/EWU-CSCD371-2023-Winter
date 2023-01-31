using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        public void TestTellJoke
        {
            JokeService jokeServiceTest = new();
            string joke = jokeServiceTest.TellJoke();
            Assert.NotNull(joke);
        }
    }
}
