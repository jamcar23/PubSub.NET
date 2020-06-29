using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    public interface IWeakDelegate : IDisposable
    {
        bool IsSubscriberAlive { get; }

        bool Contains<TSub, TDel>(TSub subscriber, TDel listener) where TDel : Delegate;

        void Invoke(params object[] args);
    }
}
