using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Diagnostics.Metrics;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        public void JokeService_TellsJoke_IsNotNull()
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
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            Jester?.TellJoke();

            // Assert
            Assert.IsFalse(stringWriter.ToString().Contains("Chuck Norris"));
        }
    }
}
