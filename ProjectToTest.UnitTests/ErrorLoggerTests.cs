
namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class ErrorLoggerTests
    {
        private ErrorLogger logger;
        [SetUp]
        public void SetUp()
        {
            logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            logger.Log("Some error");
            Assert.That(logger.LastError, Is.EqualTo("Some error"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            Guid id = Guid.Empty;
            //when Log function is called it will raise an event as 
            //a result id will be set to some guid
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("some log");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
