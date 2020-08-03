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
            hub.Unsubscribe<EventHubTests, Box<int>>(this);

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
            hub.Unsubscribe<EventHubTests, Box<int>>(this);

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
            Box<int> box = new Box<int>(-1);

            hub.Subscribe<EventHubTests, Box<int>>(this, IncrementBox);

            Assert.IsTrue(hub.Subscribe<EventHubTests, IEventHub>(this, UnsubInsideThisMethod));
            Assert.DoesNotThrow(() => hub.Publish(hub));

            hub.Publish(box);
            hub.Unsubscribe<EventHubTests, IEventHub>(this);
            hub.Unsubscribe<EventHubTests, Box<int>>(this);

            Assert.AreEqual(-1, box.Value);
        }

        [Test]
        public void TestSubscribingDuringPublishing()
        {
            IEventHub hub = EventHub;
            Box<int> box = new Box<int>(0);

            Assert.IsTrue(hub.Subscribe<EventHubTests, IEventHub>(this, SubInsideThisMethod));
            Assert.DoesNotThrow(() => hub.Publish(hub));

            hub.Publish(box);
            hub.Unsubscribe<EventHubTests, IEventHub>(this);
            hub.Unsubscribe<EventHubTests, Box<int>>(this);

            Assert.AreEqual(1, box.Value);
        }

        private void IncrementBox(Box<int> box) => box.Value++;
        private void IncrementBox2(Box<int> box) => box.Value++;

        private void UnsubInsideThisMethod(IEventHub hub)
        {
            hub.Unsubscribe<EventHubTests, IEventHub>(this);
            hub.Unsubscribe<EventHubTests, Box<int>>(this);
        }

        private void SubInsideThisMethod(IEventHub hub)
        {
            hub.Subscribe<EventHubTests, IEventHub>(this, hub => { });
            hub.Subscribe<EventHubTests, Box<int>>(this, IncrementBox);
        }
    }
}