﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace PubSubNET.Core
{
    public class EventHub : IEventHub
    {
        private readonly Dictionary<int, HashSet<IWeakDelegate>> _subs = new Dictionary<int, HashSet<IWeakDelegate>>();

        #region Publish
        public void Publish<T>(T data)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T>>())
            {
                weakDel?.Invoke(data);
            }
        }

        public void Publish<T1, T2>(T1 data1, T2 data2)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2>>())
            {
                weakDel?.Invoke(data1, data2);
            }
        }

        public void Publish<T1, T2, T3>(T1 data1, T2 data2, T3 data3)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3>>())
            {
                weakDel?.Invoke(data1, data2, data3);
            }
        }

        public void Publish<T1, T2, T3, T4>(T1 data1, T2 data2, T3 data3, T4 data4)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4>>())
            {
                weakDel?.Invoke(data1, data2, data3, data4);
            }
        }

        public void Publish<T1, T2, T3, T4, T5>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5>>())
            {
                weakDel?.Invoke(data1, data2, data3, data4, data5);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6>>())
            {
                weakDel.Invoke(data1, data2, data3, data4, data5, data6);
            }
        }

        public void Publish<T1, T2, T3, T4, T5, T6, T7>(T1 data1,
                                                        T2 data2,
                                                        T3 data3,
                                                        T4 data4,
                                                        T5 data5,
                                                        T6 data6,
                                                        T7 data7)
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7>>())
            {
                weakDel?.Invoke(data1, data2, data3, data4, data5, data6, data7);
            }
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8>>())
            {
                weakDel?.Invoke(data1,
                                                                        data2,
                                                                        data3,
                                                                        data4,
                                                                        data5,
                                                                        data6,
                                                                        data7,
                                                                        data8);
            }
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>())
            {
                weakDel?.Invoke(data1,
                                                                            data2,
                                                                            data3,
                                                                            data4,
                                                                            data5,
                                                                            data6,
                                                                            data7,
                                                                            data8,
                                                                            data9);
            }
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>())
            {
                weakDel?.Invoke(data1,
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>())
            {
                weakDel?.Invoke(data1,
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>())
            {
                weakDel?.Invoke(data1,
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>())
            {
                weakDel?.Invoke(data1,
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>())
            {
                weakDel?.Invoke(data1,
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>())
            {
                weakDel?.Invoke(data1,
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
            foreach (IWeakDelegate weakDel in GetSubscriberSet<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>())
            {
                weakDel?.Invoke(data1,
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
        }

        #endregion

        #region Subscribe

        public bool Subscribe<TSub, T1>(TSub subscriber, Action<T1> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2>(TSub subscriber, Action<T1, T2> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3>(TSub subscriber, Action<T1, T2, T3> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4>(TSub subscriber, Action<T1, T2, T3, T4> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5>(TSub subscriber, Action<T1, T2, T3, T4, T5> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener) where TSub : class => SubscribeImpl(subscriber, listener);

        private bool SubscribeImpl<TSub, TDel>(TSub subscriber, TDel listener) where TSub : class where TDel : Delegate 
            => GetSubscriberSet<TDel>().Add(new WeakDelegate(subscriber, listener.Target, listener.GetMethodInfo()));

        #endregion

        #region Unsubscribe

        public bool Unsubscribe<TSub, T1>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TSub subscriber) where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(subscriber);

        private bool UnsubscribeImpl<TSub, TDel>(TSub subscriber)
            where TSub : class
            where TDel : Delegate
        {
            int key = GetKey<TDel>();

            if (_subs.ContainsKey(key))
            {
                return _subs[key].RemoveWhere(weakDel => weakDel.Contains(subscriber)) > 0;
            }

            return false;
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private HashSet<IWeakDelegate> GetSubscriberSet<T>()
        {
            int key = GetKey<T>();

            _subs.TryGetValue(key, out HashSet<IWeakDelegate> subsSet);

            if (subsSet == null)
            {
                subsSet = new HashSet<IWeakDelegate>();
                _subs.Add(key, subsSet);
            }

            return subsSet;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int GetKey<T>() => typeof(T).GetHashCode();
    }
}
