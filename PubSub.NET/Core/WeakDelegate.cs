using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubNET.Core
{
    public class WeakDelegate : IWeakDelegate
    {
        private WeakReference _subscriberReference;
        private Delegate _listener;

        public bool IsSubscriberAlive
        {
            get
            {
                bool isAlive = _subscriberReference?.IsAlive ?? false;

                if (!isAlive)
                {
                    Dispose();
                }

                return isAlive;
            }
        }

        public Delegate Listener
        {
            get 
            {
                if (!IsSubscriberAlive)
                {
                    Dispose();
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

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _listener = null;
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
