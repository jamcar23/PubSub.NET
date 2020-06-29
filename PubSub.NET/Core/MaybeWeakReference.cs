using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    internal class MaybeWeakReference
    {
        private readonly WeakReference _delegateWeakRef;
        private readonly object _delegateStrongRef;
        private readonly bool _isStrongRef;

        public object Target => _isStrongRef ? _delegateStrongRef : _delegateWeakRef.Target;
        public bool IsAlive => _isStrongRef || _delegateWeakRef.IsAlive;

        public MaybeWeakReference(object subscriber, object delegateSource)
        {
            if (subscriber.Equals(delegateSource))
            {
                _delegateWeakRef = new WeakReference(delegateSource);
                _isStrongRef = false;
            }
            else
            {
                _delegateStrongRef = delegateSource;
                _isStrongRef = true;
            }
        }
    }
}
