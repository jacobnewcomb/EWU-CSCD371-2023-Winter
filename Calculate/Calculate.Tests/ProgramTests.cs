namespace Calculate.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ReadLineSuccess()
        {
            Program program = new Program();

            string input = "Test";
            Console.SetIn(new StreamReader(input));
            string res = program.ReadLine.Invoke();

            Assert.AreEqual(input, res);
        }
        [TestMethod]
        public void WriteLineSuccess()
        {
            Program program = new Program();
            string output = "Test";
            TextWriter textWriter = new StringWriter();
            Console.SetOut(textWriter);
            program.WriteLine.Invoke(output);
            
            Assert.AreEqual(output, textWriter.ToString());
        }
    }
}
