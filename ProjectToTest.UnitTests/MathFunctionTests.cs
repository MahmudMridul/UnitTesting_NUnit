
namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class MathFunctionTests
    {
        private MathFunctions math;

        [SetUp]
        public void SetUp()
        {
            math = new MathFunctions();
        }

        [Test]
        [Ignore("Testing Ignore")]
        public void Add_BothPositive_ReturnPositive()
        {
            int result = math.Add(10, 13);
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void Add_BiggerPositive_ReturnPositive()
        {
            int result = math.Add(12, -5);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_BiggerNegative_ReturnNegative()
        {
            int result = math.Add(-12, 10);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        [TestCase(10, 10, int.MaxValue)]
        [TestCase(12, 10, 12)]
        [TestCase(10, 14, 14)]
        public void Max_WhenCalled_ReturnMax(int first, int second, int expected)
        {
            int result = math.Max(first, second);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUptoLimit()
        {
            IEnumerable<int> result = math.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
            //CollectionAssert.AreEqual(result, new[] { 1, 3, 5 });
        }

    }
}
