using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    internal class WeakDelegate : IWeakDelegate
    {
        private WeakReference _subscriberReference;
        private Delegate _listener;

        public bool IsSubscriberAlive => _subscriberReference?.IsAlive ?? false;
        public Delegate Listener
        {
            get 
            {
                if (!IsSubscriberAlive)
                {
                    _listener = null;
                    _subscriberReference = null;
                }

                return _listener;
            }
        }

        public WeakDelegate(object subscriber, Delegate listener)
        {
            _subscriberReference = new WeakReference(subscriber ?? throw new ArgumentNullException(nameof(subscriber)));
            _listener = listener ?? throw new ArgumentNullException(nameof(listener));
        }

        public bool Contains<TSub, TDel>(TSub subscriber, TDel listener) where TDel : Delegate => 
            Listener != null && Listener.Equals(listener) && subscriber.Equals(_subscriberReference?.Target);
    }
}
