using NUnit.Framework;
using PubSub.NET.Core;
using PubSub.NET.Tests.Utils;

namespace PubSub.NET.Tests
{
    public class EventHubTests
    {

        [Test]
        public void TestPubSub()
        {
            EventHub hub = new EventHub();

            hub.Subscribe<int>(i =>
            {
                if (i > 0)
                    Assert.Pass();
                else
                    Assert.Fail();
            });

            hub.Publish(42);
        }

        [Test]
        public void TestPubNoSub()
        {
            EventHub hub = new EventHub();

            Assert.DoesNotThrow(() => hub.Publish(42));
            Assert.Pass();
        }

        [Test]
        public void TestPubMultiSubUsingMethods()
        {
            EventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            hub.Subscribe<Box<int>>(IncrementBox);
            hub.Subscribe<Box<int>>(IncrementBox2);

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestPubMultiSubUsingLambdas()
        {
            EventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            hub.Subscribe<Box<int>>(b => b.Value++);
            hub.Subscribe<Box<int>>(b => b.Value++);

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        private void IncrementBox(Box<int> box) => box.Value++;
        private void IncrementBox2(Box<int> box) => box.Value++;
    }
}