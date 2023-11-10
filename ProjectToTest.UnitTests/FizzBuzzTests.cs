using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        public void GetOutput_BothDivisible_ReturnFizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_3Divisible_ReturnFizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetOutput(9);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_5Divisible_ReturnBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetOutput(10);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NoneDivisible_ReturnNumber()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.GetOutput(4);
            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
