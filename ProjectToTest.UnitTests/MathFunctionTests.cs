using ProjectToTest;

namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class MathFunctionTests
    {
        [Test]
        public void Add_BothPositive_ReturnPositive()
        {
            MathFunctions func = new MathFunctions();
            int result = func.Add(10, 13);
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void Add_BiggerPositive_ReturnPositive()
        {
            MathFunctions func = new MathFunctions();
            int result = func.Add(12, -5);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_BiggerNegative_ReturnNegative()
        {
            MathFunctions func = new MathFunctions();
            int result = func.Add(-12, 10);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Max_BothEqual_ReturnIntMax()
        {
            MathFunctions func = new MathFunctions();
            int result = func.Max(10, 10);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Max_FirstBigger_ReturnFirst()
        {
            MathFunctions func = new MathFunctions();
            int result = func.Max(13, 10);
            Assert.That(result, Is.EqualTo(13));
        }

    }
}
