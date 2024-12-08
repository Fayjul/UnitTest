using MyStackApp;
using NUnit.Framework;

namespace MyStackAppTest
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void EmptyStackSize()
        {
            var stack = new MyStack<int>();
            Assert.AreEqual(0, stack.Size());
        }

        [Test]
        public void SizeAfterOnePush()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            Assert.AreNotEqual(0, stack.Size());
        }

        [Test]
        public void SizeAfterThreePush()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Size());
        }
        [Test]
        public void SizeAfterThreePushAndOnePop()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.AreEqual(2, stack.Size());
        }

        [Test]
        public void PushAndPopSameObject()
        {
            var stack = new MyStack<object>();
            var person = new
            {
                Name = "John Doe",
                Age = 30,
                Address = "123 Main St"
            };
            stack.Push(person);
            var personAfterPop = stack.Pop();
            Assert.AreEqual(person, personAfterPop);
        }
        [Test]
        public void PushAndPopSameThreeObject()
        {
            var stack = new MyStack<object>();
            var person1 = new
            {
                Name = "John Doe",
                Age = 30,
                Address = "123 Main St"
            };
            var person2 = new
            {
                Name = "John Boe",
                Age = 30,
                Address = "123 Main St"
            };
            var person3 = new
            {
                Name = "John Coe",
                Age = 30,
                Address = "123 Main St"
            };
            stack.Push(person1);
            stack.Push(person2);
            stack.Push(person3);
            var person3AfterPop = stack.Pop();
            var person2AfterPop = stack.Pop();
            var person1AfterPop = stack.Pop();
            Assert.AreSame(person1, person1AfterPop);
            Assert.AreSame(person2, person2AfterPop);
            Assert.AreSame(person3, person3AfterPop);
        }

        [Test]
        public void PopInEmptyStack()
        {
            var stack = new MyStack<int>();
            Assert.AreEqual("Stack underflow", stack.Pop());
        }

    }
}
