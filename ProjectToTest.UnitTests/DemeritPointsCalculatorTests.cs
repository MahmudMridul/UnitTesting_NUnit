

namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsInValid_ThrowException(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Throws.InstanceOf<Exception>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int points)
        {
            int result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(points));
        }
    }
}
