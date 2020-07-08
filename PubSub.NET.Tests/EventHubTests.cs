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
            IEventHub hub = EventHub;

            Assert.IsTrue(hub.Subscribe<EventHubTests, int>(this, i =>
            {
                Assert.Greater(i, 0);
            }));

            hub.Publish(42);
        }

        [Test]
        public void TestPubNoSub()
        {
            IEventHub hub = EventHub;

            Assert.DoesNotThrow(() => hub.Publish(42));
            Assert.Pass();
        }

        [Test]
        public void TestPubMultiSubUsingMethods()
        {
            IEventHub hub = EventHub;
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<EventHubTests, Box<int>>(this, IncrementBox));
            Assert.IsTrue(hub.Subscribe<EventHubTests, Box<int>>(this, IncrementBox2));

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestPubMultiSubUsingLambdas()
        {
            IEventHub hub = EventHub;
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<EventHubTests, Box<int>>(this, b => b.Value++));
            Assert.IsTrue(hub.Subscribe<EventHubTests, Box<int>>(this, b => b.Value++));

            hub.Publish(box);
            Assert.AreEqual(2, box.Value);
        }

        [Test]
        public void TestSubUnsubUsingMethods()
        {
            IEventHub hub = EventHub;

            Assert.IsTrue(hub.Subscribe<EventHubTests, Box<int>>(this, IncrementBox));
            Assert.IsTrue(hub.Unsubscribe<EventHubTests, Box<int>>(this));
        }

        [Test]
        public void TestNoSubUnsubUsingMethods()
        {
            IEventHub hub = EventHub;

            Assert.IsFalse(hub.Unsubscribe<EventHubTests, Box<int>>(this));
        }

        [Test]
        // todo doesn't seem possible since each lambda is a different instance and thus a different method
        // todo look into whether or not this should be a supported feature; fixing this will make TestPubMultiSubUsingLambdas fail
        public void TestSubUnsubUsingLambdas() 
        {
            IEventHub hub = EventHub;
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<EventHubTests, Box<int>>(this, b => b.Value++));
            Assert.IsTrue(hub.Unsubscribe<EventHubTests, Box<int>>(this));
        }

        [Test]
        public void TestUnsubscribingDuringPublishing()
        {
            IEventHub hub = EventHub;

            Assert.IsTrue(hub.Subscribe<EventHubTests, IEventHub>(this, UnsubInsideThisMethod));
            Assert.DoesNotThrow(() => hub.Publish(hub));
        }

        private void IncrementBox(Box<int> box) => box.Value++;
        private void IncrementBox2(Box<int> box) => box.Value++;

        private void UnsubInsideThisMethod(IEventHub hub)
        {
            hub.Unsubscribe<EventHubTests, IEventHub>(this);
        }
    }
}