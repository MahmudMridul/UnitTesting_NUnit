using ProjectToTest;

namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class MathFunctionTests
    {
        private MathFunctions func;

        [SetUp]
        public void SetUp()
        {
            func = new MathFunctions();
        }

        [Test]
        public void Add_BothPositive_ReturnPositive()
        {
            int result = func.Add(10, 13);
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void Add_BiggerPositive_ReturnPositive()
        {
            int result = func.Add(12, -5);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_BiggerNegative_ReturnNegative()
        {
            int result = func.Add(-12, 10);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        [TestCase(10, 10, int.MaxValue)]
        [TestCase(12, 10, 12)]
        [TestCase(10, 14, 14)]
        public void Max_WhenCalled_ReturnMax(int first, int second, int expected)
        {
            int result = func.Max(first, second);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
