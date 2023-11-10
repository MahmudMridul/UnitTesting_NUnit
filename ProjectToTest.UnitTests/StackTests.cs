

namespace ProjectToTest.UnitTests
{
    [TestFixture]
    internal class StackTests
    {
        private Stack<string> stack;

        [SetUp]
        public void SetUp()
        {
            stack = new Stack<string>();
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddToStack()
        {
            stack.Push("first");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(stack.Count, Is.Zero);
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Pop(), Throws.InstanceOf<Exception>());
        }

        [Test]
        public void Pop_StackHasObjects_ReturnObjectOnTop()
        {
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("third"));
        }

        [Test]
        public void Pop_StackHasObjects_RemoveObjectOnTop()
        {
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Peek(), Throws.InstanceOf<Exception>());
        }

        [Test]
        public void Peek_StackHasObjects_ReturnObjectOnTop()
        {
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            var result = stack.Peek();
            Assert.That(result, Is.EqualTo("third"));
        }

        [Test]
        public void Peek_StackHasObjects_DoesNotRemoveObjectOnTop()
        {
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            stack.Peek();
            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
