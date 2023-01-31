using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Diagnostics.Metrics;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        public void JokeService_TellsJoke()
        {
            //Arrange
            Jester jester = new Jester(new JokeService(), new JokeServiceWriter());

            //Act
            string joke = jester.TellJoke();

            //Assert
            Assert.IsNotNull(joke);
        }
        [TestMethod]
        public void JokeService_DoesntTellChuckNorrisJokes_Please() 
        {
            //Arrange
            Jester jester = new Jester(new JokeService(), new JokeServiceWriter());

            //Act
            string [] jokes = new string[10];
            for(int i = 0; i < jokes.Length; i++) jokes[i] = jester.TellJoke();

            //Assert
            for (int i = 0; i < jokes.Length; i++) Assert.AreEqual(false, jokes[i].Contains("Chuck Norris", System.StringComparison.CurrentCulture));
        }
    }
}
