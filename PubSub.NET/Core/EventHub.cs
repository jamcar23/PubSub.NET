using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubSub.NET.Core
{
    public class EventHub : IEventHub
    {
        private readonly Dictionary<int, HashSet<Delegate>> _subs = new Dictionary<int, HashSet<Delegate>>();

        #region Publish
        public void Publish<T>(T data)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T>>())
            {
                (del as Action<T>)?.Invoke(data);
            }
        }

        public void Publish<T1, T2>(T1 data1, T2 data2)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2>>())
            {
                (del as Action<T1, T2>)?.Invoke(data1, data2);
            }
        }

        public void Publish<T1, T2, T3>(T1 data1, T2 data2, T3 data3)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3>>())
            {
                (del as Action<T1, T2, T3>)?.Invoke(data1, data2, data3);
            }
        }

        public void Publish<T1, T2, T3, T4>(T1 data1, T2 data2, T3 data3, T4 data4)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4>>())
            {
                (del as Action<T1, T2, T3, T4>)?.Invoke(data1, data2, data3, data4);
            }
        }

        public void Publish<T1, T2, T3, T4, T5>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5>>())
            {
                (del as Action<T1, T2, T3, T4, T5>)?.Invoke(data1, data2, data3, data4, data5);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6>)?.Invoke(data1, data2, data3, data4, data5, data6);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7>)?.Invoke(data1, data2, data3, data4, data5, data6, data7);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12, data13);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13, T14 data14)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12, data13, data14);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13, T14 data14, T15 data15)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12, data13, data14, data15);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13, T14 data14, T15 data15, T16 data16)
        {
            foreach (Delegate del in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>())
            {
                (del as Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>)?.Invoke(data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12, data13, data14, data15, data16);
            }
        }

        #endregion

        #region Subscribe

        public bool Subscribe<T>(Action<T> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2>(Action<T1, T2> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3>(Action<T1, T2, T3> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4>(Action<T1, T2, T3, T4> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener) => SubscribeImpl(listener);

        public bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener) => SubscribeImpl(listener);

        private bool SubscribeImpl<T>(T listener) where T : Delegate => GetSubscriberSet<T>().Add(listener);

        #endregion

        #region Unsubscribe

        public bool Unsubscribe<T>(Action<T> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2>(Action<T1, T2> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3>(Action<T1, T2, T3> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4>(Action<T1, T2, T3, T4> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener) => UnsubscribeImpl(listener);

        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener) => UnsubscribeImpl(listener);

        private bool UnsubscribeImpl<T>(T listener) where T : Delegate
        {
            int key = GetKey<T>();

            if (_subs.ContainsKey(key))
            {
                return _subs[key].Remove(listener);
            }

            return false;
        }

        #endregion

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
