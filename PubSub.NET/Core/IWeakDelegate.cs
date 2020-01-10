using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    public interface IWeakDelegate : IDisposable
    {
        bool IsSubscriberAlive { get; }

        Delegate Listener { get; }

        bool Contains<TSub, TDel>(TSub subscriber, TDel listener) where TDel : Delegate;
    }
}
