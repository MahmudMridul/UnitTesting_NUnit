
namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class StringFunctionsTests
    {
        [Test]
        public void SurroundUnderScore_WhenCalled_ReturnUnderScoreSurroundedString()
        {
            StringFunctions func = new StringFunctions();
            string result = func.SurroundUnderScore("A quick brown fox");
            //Specific
            Assert.That(result, Is.EqualTo("__A quick brown fox__"));

            //General
            //Assert.That(result, Does.StartWith("__"));
            //Assert.That(result, Does.EndWith("__"));
            //Assert.That(result, Does.Contain("A quick brown fox"));
        }
    }
}
