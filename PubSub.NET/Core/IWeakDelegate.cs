using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    public interface IWeakDelegate : IDisposable
    {
        bool IsSubscriberAlive { get; }

        bool Contains<TSub>(TSub subscriber);

        void Invoke(params object[] args);
    }
}
