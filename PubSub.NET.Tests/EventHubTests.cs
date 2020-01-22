using NUnit.Framework;
using PubSubNET.Core;
using PubSubNET.Tests.Utils;

namespace PubSubNET.Tests
{
    public abstract class EventHubTests
    {
        protected abstract IEventHub EventHub { get; }

        [Test]
        public void TestPubSub()
        {
            IEventHub hub = new EventHub();

            Assert.IsTrue(hub.Subscribe<int>(i =>
            {
                Assert.Greater(i, 0);
            }));

            hub.Publish(42);
        }

        [Test]
        public void TestPubNoSub()
        {
            IEventHub hub = new EventHub();

            Assert.DoesNotThrow(() => hub.Publish(42));
            Assert.Pass();
        }

        [Test]
        public void TestPubMultiSubUsingMethods()
        {
            IEventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<Box<int>>(IncrementBox));
            Assert.IsTrue(hub.Subscribe<Box<int>>(IncrementBox2));

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestPubMultiSubUsingLambdas()
        {
            IEventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<Box<int>>(b => b.Value++));
            Assert.IsTrue(hub.Subscribe<Box<int>>(b => b.Value++));

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestSubUnsubUsingMethods()
        {
            IEventHub hub = new EventHub();

            Assert.IsTrue(hub.Subscribe<Box<int>>(IncrementBox));
            Assert.IsTrue(hub.Unsubscribe<Box<int>>(IncrementBox));
        }

        [Test]
        public void TestNoSubUnsubUsingMethods()
        {
            IEventHub hub = new EventHub();

            Assert.IsFalse(hub.Unsubscribe<Box<int>>(IncrementBox));
        }

        [Test]
        // todo doesn't seem possible since each lambda is a different instance and thus a different method
        // todo look into whether or not this should be a supported feature; fixing this will make TestPubMultiSubUsingLambdas fail
        public void TestSubUnsubUsingLambdas() 
        {
            IEventHub hub = new EventHub();
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<Box<int>>(b => b.Value++));
            Assert.IsTrue(hub.Unsubscribe<Box<int>>(b => b.Value++));
        }

        [Test]
        public void TestUnsubscribingDuringPublishing()
        {
            IEventHub hub = new EventHub();

            Assert.IsTrue(hub.Subscribe<IEventHub>(UnsubInsideThisMethod));
            Assert.DoesNotThrow(() => hub.Publish(hub));
        }

        private void IncrementBox(Box<int> box) => box.Value++;
        private void IncrementBox2(Box<int> box) => box.Value++;

        private void UnsubInsideThisMethod(IEventHub hub)
        {
            hub.Unsubscribe<IEventHub>(UnsubInsideThisMethod);
        }
    }
}