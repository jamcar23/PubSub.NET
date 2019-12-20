using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PubSub.NET.Core
{
    public class EventHub : IEventHub
    {
        private readonly Dictionary<int, HashSet<Delegate>> _subs = new Dictionary<int, HashSet<Delegate>>();

        public void Publish<T>(T data)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T>>())
            {
                (del as Action<T>)?.Invoke(data);
            }
        }

        public bool Subscribe<T>(Action<T> listener)
        {
            return GetSubscriberSet<Action<T>>().Add(listener);
        }

        public bool Unsubscribe<T>(Action<T> listener) => Unsubscribe<Action<T>>(listener);

        private bool Unsubscribe<T>(T listener) where T : Delegate
        {
            int key = GetKey<T>();

            if (_subs.ContainsKey(key))
            {
                return _subs[key].Remove(listener);
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private HashSet<Delegate> GetSubscriberSet<T>()
        {
            int key = GetKey<T>();

            _subs.TryGetValue(key, out HashSet<Delegate> subsSet);

            if (subsSet == null)
            {
                subsSet = new HashSet<Delegate>();
                _subs.Add(key, subsSet);
            }

            return subsSet;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int GetKey<T>() => typeof(T).GetHashCode();
    }
}
