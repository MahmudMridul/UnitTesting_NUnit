
namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            ErrorLogger logger = new ErrorLogger();
            logger.Log("Some error");
            Assert.That(logger.LastError, Is.EqualTo("Some error"));
        }
    }
}
