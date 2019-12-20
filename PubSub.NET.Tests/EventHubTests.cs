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

            Assert.IsTrue(hub.Subscribe<int>(i =>
            {
                Assert.Greater(i, 0);
            }));

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

            Assert.IsTrue(hub.Subscribe<Box<int>>(IncrementBox));
            Assert.IsTrue(hub.Subscribe<Box<int>>(IncrementBox2));

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestPubMultiSubUsingLambdas()
        {
            EventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<Box<int>>(b => b.Value++));
            Assert.IsTrue(hub.Subscribe<Box<int>>(b => b.Value++));

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestSubUnsubUsingMethods()
        {
            EventHub hub = new EventHub();

            Assert.IsTrue(hub.Subscribe<Box<int>>(IncrementBox));
            Assert.IsTrue(hub.Unsubscribe<Box<int>>(IncrementBox));
        }

        [Test]
        public void TestNoSubUnsubUsingMethods()
        {
            EventHub hub = new EventHub();

            Assert.IsFalse(hub.Unsubscribe<Box<int>>(IncrementBox));
        }

        [Test]
        // todo not possible using hashsets since each lambda is a different instance with different hashcodes
        // todo look into whether or not this should be a supported feature
        public void TestSubUnsubUsingLambdas() 
        {
            EventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<Box<int>>(b => b.Value++));
            Assert.IsTrue(hub.Unsubscribe<Box<int>>(b => b.Value++));
        }

        private void IncrementBox(Box<int> box) => box.Value++;
        private void IncrementBox2(Box<int> box) => box.Value++;
    }
}