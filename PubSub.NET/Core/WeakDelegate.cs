using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PubSubNET.Core
{
    internal class WeakDelegate : IWeakDelegate
    {
        private WeakReference _subscriberReference;
        private MaybeWeakReference _delegateSource;
        private MethodInfo _listener;

        public bool IsSubscriberAlive
        {
            get
            {
                bool isAlive = (_subscriberReference?.IsAlive ?? false) || (_delegateSource?.IsAlive ?? false);

                if (!isAlive)
                {
                    Dispose();
                }

                return isAlive;
            }
        }

        public WeakDelegate(object subscriber, object target, MethodInfo listener)
        {
            _subscriberReference = new WeakReference(subscriber ?? throw new ArgumentNullException(nameof(subscriber)));
            _delegateSource = new MaybeWeakReference(subscriber, target ?? throw new ArgumentNullException(nameof(target)));
            _listener = listener ?? throw new ArgumentNullException(nameof(listener));
        }

        public bool Contains<TSub>(TSub subscriber) =>
            ((object)subscriber) == _subscriberReference?.Target;

        public void Invoke(params object[] args)
        {
            if (args?.Length != _listener.GetParameters().Length)
            {
                throw new ArgumentException("Invoke arguments don't match subscriber's arguments.");
            }

            if (_listener.IsStatic)
            {
                _listener.Invoke(null, args);
            }

            object target = _delegateSource.Target;

            if (target == null)
            {
                return;
            }

            _listener.Invoke(target, args);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _listener = null;
                    _delegateSource = null;
                    _subscriberReference = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~WeakDelegate()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion
    }
}
