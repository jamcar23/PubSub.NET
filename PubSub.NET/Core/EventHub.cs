using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PubSubNET.Core
{
    public class EventHub : IEventHub
    {
        private readonly Dictionary<int, Delegate> _subs = new Dictionary<int, Delegate>();

        #region Publish
        public void Publish<T>(T data) { (GetSubscriberSet<Action<T>>() as Action<T>)?.Invoke(data); }

        public void Publish<T1, T2>(T1 data1, T2 data2)
        { (GetSubscriberSet<Action<T1, T2>>() as Action<T1, T2>)?.Invoke(data1, data2); }

        public void Publish<T1, T2, T3>(T1 data1, T2 data2, T3 data3)
        { (GetSubscriberSet<Action<T1, T2, T3>>() as Action<T1, T2, T3>)?.Invoke(data1, data2, data3); }

        public void Publish<T1, T2, T3, T4>(T1 data1, T2 data2, T3 data3, T4 data4)
        { (GetSubscriberSet<Action<T1, T2, T3, T4>>() as Action<T1, T2, T3, T4>)?.Invoke(data1, data2, data3, data4); }

        public void Publish<T1, T2, T3, T4, T5>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5>>() as
                Action<T1, T2, T3, T4, T5>)?.Invoke(data1,
                                                    data2,
                                                    data3,
                                                    data4,
                                                    data5);
        }

        public void Publish<T1, T2, T3, T4, T5, T6>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6>>() as
                Action<T1, T2, T3, T4, T5, T6>)?.Invoke(data1,
                                                        data2,
                                                        data3,
                                                        data4,
                                                        data5,
                                                        data6);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7>(T1 data1,
                                                        T2 data2,
                                                        T3 data3,
                                                        T4 data4,
                                                        T5 data5,
                                                        T6 data6,
                                                        T7 data7)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7>>() as
                Action<T1, T2, T3, T4, T5, T6, T7>)?.Invoke(data1,
                                                            data2,
                                                            data3,
                                                            data4,
                                                            data5,
                                                            data6,
                                                            data7);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8>(T1 data1,
                                                            T2 data2,
                                                            T3 data3,
                                                            T4 data4,
                                                            T5 data5,
                                                            T6 data6,
                                                            T7 data7,
                                                            T8 data8)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8>)?.Invoke(data1,
                                                                data2,
                                                                data3,
                                                                data4,
                                                                data5,
                                                                data6,
                                                                data7,
                                                                data8);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 data1,
                                                                T2 data2,
                                                                T3 data3,
                                                                T4 data4,
                                                                T5 data5,
                                                                T6 data6,
                                                                T7 data7,
                                                                T8 data8,
                                                                T9 data9)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>)?.Invoke(data1,
                                                                    data2,
                                                                    data3,
                                                                    data4,
                                                                    data5,
                                                                    data6,
                                                                    data7,
                                                                    data8,
                                                                    data9);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 data1,
                                                                     T2 data2,
                                                                     T3 data3,
                                                                     T4 data4,
                                                                     T5 data5,
                                                                     T6 data6,
                                                                     T7 data7,
                                                                     T8 data8,
                                                                     T9 data9,
                                                                     T10 data10)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)?.Invoke(data1,
                                                                         data2,
                                                                         data3,
                                                                         data4,
                                                                         data5,
                                                                         data6,
                                                                         data7,
                                                                         data8,
                                                                         data9,
                                                                         data10);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 data1,
                                                                          T2 data2,
                                                                          T3 data3,
                                                                          T4 data4,
                                                                          T5 data5,
                                                                          T6 data6,
                                                                          T7 data7,
                                                                          T8 data8,
                                                                          T9 data9,
                                                                          T10 data10,
                                                                          T11 data11)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)?.Invoke(data1,
                                                                              data2,
                                                                              data3,
                                                                              data4,
                                                                              data5,
                                                                              data6,
                                                                              data7,
                                                                              data8,
                                                                              data9,
                                                                              data10,
                                                                              data11);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 data1,
                                                                               T2 data2,
                                                                               T3 data3,
                                                                               T4 data4,
                                                                               T5 data5,
                                                                               T6 data6,
                                                                               T7 data7,
                                                                               T8 data8,
                                                                               T9 data9,
                                                                               T10 data10,
                                                                               T11 data11,
                                                                               T12 data12)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)?.Invoke(data1,
                                                                                   data2,
                                                                                   data3,
                                                                                   data4,
                                                                                   data5,
                                                                                   data6,
                                                                                   data7,
                                                                                   data8,
                                                                                   data9,
                                                                                   data10,
                                                                                   data11,
                                                                                   data12);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 data1,
                                                                                    T2 data2,
                                                                                    T3 data3,
                                                                                    T4 data4,
                                                                                    T5 data5,
                                                                                    T6 data6,
                                                                                    T7 data7,
                                                                                    T8 data8,
                                                                                    T9 data9,
                                                                                    T10 data10,
                                                                                    T11 data11,
                                                                                    T12 data12,
                                                                                    T13 data13)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)?.Invoke(data1,
                                                                                        data2,
                                                                                        data3,
                                                                                        data4,
                                                                                        data5,
                                                                                        data6,
                                                                                        data7,
                                                                                        data8,
                                                                                        data9,
                                                                                        data10,
                                                                                        data11,
                                                                                        data12,
                                                                                        data13);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 data1,
                                                                                         T2 data2,
                                                                                         T3 data3,
                                                                                         T4 data4,
                                                                                         T5 data5,
                                                                                         T6 data6,
                                                                                         T7 data7,
                                                                                         T8 data8,
                                                                                         T9 data9,
                                                                                         T10 data10,
                                                                                         T11 data11,
                                                                                         T12 data12,
                                                                                         T13 data13,
                                                                                         T14 data14)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)?.Invoke(data1,
                                                                                             data2,
                                                                                             data3,
                                                                                             data4,
                                                                                             data5,
                                                                                             data6,
                                                                                             data7,
                                                                                             data8,
                                                                                             data9,
                                                                                             data10,
                                                                                             data11,
                                                                                             data12,
                                                                                             data13,
                                                                                             data14);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 data1,
                                                                                              T2 data2,
                                                                                              T3 data3,
                                                                                              T4 data4,
                                                                                              T5 data5,
                                                                                              T6 data6,
                                                                                              T7 data7,
                                                                                              T8 data8,
                                                                                              T9 data9,
                                                                                              T10 data10,
                                                                                              T11 data11,
                                                                                              T12 data12,
                                                                                              T13 data13,
                                                                                              T14 data14,
                                                                                              T15 data15)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)?.Invoke(data1,
                                                                                                  data2,
                                                                                                  data3,
                                                                                                  data4,
                                                                                                  data5,
                                                                                                  data6,
                                                                                                  data7,
                                                                                                  data8,
                                                                                                  data9,
                                                                                                  data10,
                                                                                                  data11,
                                                                                                  data12,
                                                                                                  data13,
                                                                                                  data14,
                                                                                                  data15);
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 data1,
                                                                                                   T2 data2,
                                                                                                   T3 data3,
                                                                                                   T4 data4,
                                                                                                   T5 data5,
                                                                                                   T6 data6,
                                                                                                   T7 data7,
                                                                                                   T8 data8,
                                                                                                   T9 data9,
                                                                                                   T10 data10,
                                                                                                   T11 data11,
                                                                                                   T12 data12,
                                                                                                   T13 data13,
                                                                                                   T14 data14,
                                                                                                   T15 data15,
                                                                                                   T16 data16)
        {
            (GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() as
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>)?.Invoke(data1,
                                                                                                       data2,
                                                                                                       data3,
                                                                                                       data4,
                                                                                                       data5,
                                                                                                       data6,
                                                                                                       data7,
                                                                                                       data8,
                                                                                                       data9,
                                                                                                       data10,
                                                                                                       data11,
                                                                                                       data12,
                                                                                                       data13,
                                                                                                       data14,
                                                                                                       data15,
                                                                                                       data16);
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

        private bool SubscribeImpl<T>(T listener)
            where T : Delegate
        {
            Delegate subs = GetSubscriberSet<T>();

            if (subs?.GetInvocationList().Contains(listener) ?? false)
                return false;

            int key = GetKey<T>();

            _subs[key] = Delegate.Combine(_subs[key], listener);

            return true;
        }

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

        private bool UnsubscribeImpl<T>(T listener)
            where T : Delegate
        {
            int key = GetKey<T>();

            if (_subs.ContainsKey(key))
            {
                Delegate oldDel = _subs[key];
                _subs[key] = Delegate.Remove(_subs[key], listener);

                return oldDel != _subs[key];
            }

            return false;
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Delegate GetSubscriberSet<T>()
        {
            int key = GetKey<T>();

            if (!_subs.TryGetValue(key, out Delegate del))
            {
                _subs.Add(key, null);
            }

            return del;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int GetKey<T>() => typeof(T).GetHashCode();
    }
}
