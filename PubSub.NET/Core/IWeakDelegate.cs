using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    internal interface IWeakDelegate
    {
        bool IsSubscriberAlive { get; }

        Delegate Listener { get; }

        bool Contains<TSub, TDel>(TSub subscriber, TDel listener) where TDel : Delegate;
    }
}
