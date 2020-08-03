using NUnit.Framework;
using PubSubNET.Core;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PubSubNET.Tests
{
    public class WeakDelegateTest
    {
        [Test]
        public void TestDisposeWithMethod()
        {
            IWeakDelegate weakDel = null;

            new Action(() =>
            {
                Subscriber sub = new Subscriber();

                weakDel = new WeakDelegate(sub, sub, ((Action<bool>)sub.Listener).GetMethodInfo());

                Assert.IsTrue(weakDel.IsSubscriberAlive);

                sub = null;
            })();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Assert.IsFalse(weakDel.IsSubscriberAlive);
        }

        [Test]
        public void TestSubscriberShouldBeCollected()
        {
            new Action(() =>
            {
                Subscriber sub = new Subscriber();

                PubSub.Subscribe<Subscriber, bool>(sub, sub.Listener);
            })();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            PubSub.Publish(true);
        }

        [Test]
        public void TestShouldBeCollectedIfCallbackTargetIsSubscriber()
        {
            WeakReference wr = null;

            new Action(() =>
            {
                Subscriber sub = new Subscriber();

                wr = new WeakReference(sub);

                PubSub.Subscribe<Subscriber, bool>(sub, sub.Listener);
            })();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            PubSub.Publish(true);

            Assert.IsFalse(wr.IsAlive);
        }

        [Test]
        public void TestNotCollectedIfSubscriberIsNotTheCallbackTarget()
        {
            WeakReference wr = null;

            new Action(() =>
            {
                Subscriber sub = new Subscriber();

                wr = new WeakReference(sub);

                PubSub.Subscribe<Subscriber, bool>(sub, (_) => sub.MakeSuccessful());
            })();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Assert.IsTrue(wr.IsAlive);
            Assert.IsNotNull(wr.Target as Subscriber);
            Assert.IsFalse(((Subscriber)wr.Target).Successful);

            PubSub.Publish(true);

            Assert.IsTrue(((Subscriber)wr.Target).Successful);
        }

        [Test]
        public void TestSubscriberCollectableAfterUnsubscribeEvenIfHeldByClosure()
        {
            WeakReference wr = null;

            new Action(() =>
            {
                Subscriber sub = new Subscriber();

                wr = new WeakReference(sub);

                PubSub.Subscribe<Subscriber, bool>(sub, (_) => sub.MakeSuccessful());
            })();

            Assert.IsTrue(wr.IsAlive);
            Assert.IsNotNull(wr.Target as Subscriber);

            PubSub.Unsubscribe<Subscriber, bool>(wr.Target as Subscriber);

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private class Subscriber
        {
            public bool Successful { get; private set; }

            public void Listener(bool b)
            {
                Successful = b;
            }

            public void MakeSuccessful()
            {
                Successful = true;
            }
        }
    }
}
