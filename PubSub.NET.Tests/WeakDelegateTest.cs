using NUnit.Framework;
using PubSubNET.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Tests
{
    public class WeakDelegateTest
    {
        [Test]
        public void TestDisposeWithMethod()
        {
            Subscriber sub = new Subscriber();
            WeakDelegate weakDel = new WeakDelegate(sub, (Action<object>)sub.Listener);

            Assert.IsTrue(weakDel.IsSubscriberAlive);
            Assert.IsNotNull(weakDel.Listener);

            sub = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Assert.IsFalse(weakDel.IsSubscriberAlive);
            Assert.IsNull(weakDel.Listener);
        }

        private class Subscriber
        {
            public void Listener(object obj)
            {

            }
        }
    }
}
