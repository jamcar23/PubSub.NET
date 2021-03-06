﻿using ConcurrentCollections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace PubSubNET.Core
{
    internal class EventHub : IEventHub
    {
        private readonly ConcurrentDictionary<int, ConcurrentHashSet<IWeakDelegate>> _subs = new ConcurrentDictionary<int, ConcurrentHashSet<IWeakDelegate>>();

        #region Publish

        public void Publish<T>(T data) => PublishImpl<Action<T>>(data);

        public void Publish<T1, T2>(T1 data1, T2 data2) => PublishImpl<Action<T1, T2>>(data1, data2);

        public void Publish<T1, T2, T3>(T1 data1, T2 data2, T3 data3) => PublishImpl<Action<T1, T2, T3>>(data1,
                                                                                                         data2,
                                                                                                         data3);

        public void Publish<T1, T2, T3, T4>(T1 data1, T2 data2, T3 data3, T4 data4) => PublishImpl<Action<T1, T2, T3, T4>>(data1,
                                                                                                                           data2,
                                                                                                                           data3,
                                                                                                                           data4);

        public void Publish<T1, T2, T3, T4, T5>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5) => PublishImpl<Action<T1, T2, T3, T4, T5>>(data1,
                                                                                                                                             data2,
                                                                                                                                             data3,
                                                                                                                                             data4,
                                                                                                                                             data5);

        public void Publish<T1, T2, T3, T4, T5, T6>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6) => PublishImpl<Action<T1, T2, T3, T4, T5, T6>>(data1,
                                                                                                                                                               data2,
                                                                                                                                                               data3,
                                                                                                                                                               data4,
                                                                                                                                                               data5,
                                                                                                                                                               data6);

        public void Publish<T1, T2, T3, T4, T5, T6, T7>(T1 data1,
                                                        T2 data2,
                                                        T3 data3,
                                                        T4 data4,
                                                        T5 data5,
                                                        T6 data6,
                                                        T7 data7) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7>>(data1,
                                                                                                                     data2,
                                                                                                                     data3,
                                                                                                                     data4,
                                                                                                                     data5,
                                                                                                                     data6,
                                                                                                                     data7);

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8>(T1 data1,
                                                            T2 data2,
                                                            T3 data3,
                                                            T4 data4,
                                                            T5 data5,
                                                            T6 data6,
                                                            T7 data7,
                                                            T8 data8) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8>>(data1,
                                                                                                                             data2,
                                                                                                                             data3,
                                                                                                                             data4,
                                                                                                                             data5,
                                                                                                                             data6,
                                                                                                                             data7,
                                                                                                                             data8);

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 data1,
                                                                T2 data2,
                                                                T3 data3,
                                                                T4 data4,
                                                                T5 data5,
                                                                T6 data6,
                                                                T7 data7,
                                                                T8 data8,
                                                                T9 data9) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(data1,
                                                                                                                                     data2,
                                                                                                                                     data3,
                                                                                                                                     data4,
                                                                                                                                     data5,
                                                                                                                                     data6,
                                                                                                                                     data7,
                                                                                                                                     data8,
                                                                                                                                     data9);

        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 data1,
                                                                     T2 data2,
                                                                     T3 data3,
                                                                     T4 data4,
                                                                     T5 data5,
                                                                     T6 data6,
                                                                     T7 data7,
                                                                     T8 data8,
                                                                     T9 data9,
                                                                     T10 data10) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(data1,
                                                                                                                                                 data2,
                                                                                                                                                 data3,
                                                                                                                                                 data4,
                                                                                                                                                 data5,
                                                                                                                                                 data6,
                                                                                                                                                 data7,
                                                                                                                                                 data8,
                                                                                                                                                 data9,
                                                                                                                                                 data10);

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
                                                                          T11 data11) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(data1,
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
                                                                               T12 data12) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(data1,
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
                                                                                    T13 data13) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(data1,
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
                                                                                         T14 data14) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(data1,
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
                                                                                              T15 data15) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(data1,
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
                                                                                                   T16 data16) => PublishImpl<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(data1,
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

        private void PublishImpl<TDel>(params object[] args)
            where TDel : Delegate
        {
            foreach (IWeakDelegate weakDel in GetSubscriberSet<TDel>())
            {
                weakDel?.Invoke(args);
            }
        }

        #endregion Publish

        #region Subscribe

        public bool Subscribe<TSub, T1>(TSub subscriber, Action<T1> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2>(TSub subscriber, Action<T1, T2> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3>(TSub subscriber, Action<T1, T2, T3> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4>(TSub subscriber, Action<T1, T2, T3, T4> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5>(TSub subscriber, Action<T1, T2, T3, T4, T5> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7>(TSub subscriber,
                                                                Action<T1, T2, T3, T4, T5, T6, T7> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8>(TSub subscriber,
                                                                    Action<T1, T2, T3, T4, T5, T6, T7, T8> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TSub subscriber,
                                                                        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TSub subscriber,
                                                                             Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TSub subscriber,
                                                                                  Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TSub subscriber,
                                                                                       Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TSub subscriber,
                                                                                            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TSub subscriber,
                                                                                                 Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TSub subscriber,
                                                                                                      Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        public bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TSub subscriber,
                                                                                                           Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener)
            where TSub : class => SubscribeImpl(subscriber, listener);

        private bool SubscribeImpl<TSub, TDel>(TSub subscriber, TDel listener)
            where TSub : class
            where TDel : Delegate
        {
            int key = GetKey<TDel>();
            IWeakDelegate weakDel = new WeakDelegate(subscriber, listener.Target, listener.GetMethodInfo());

            return Subscribe(key, weakDel);
        }

        private bool Subscribe(int key, IWeakDelegate weakDel)
        {
            return GetSubscriberSet(key).Add(weakDel);
        }

        #endregion Subscribe

        #region Unsubscribe

        public bool Unsubscribe<TSub, T1>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(subscriber);

        public bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TSub subscriber)
            where TSub : class => UnsubscribeImpl<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(subscriber);

        private bool UnsubscribeImpl<TSub, TDel>(TSub subscriber)
            where TSub : class
            where TDel : Delegate
        {
            int key = GetKey<TDel>();

            if (_subs.ContainsKey(key))
            {
                return Unsubscribe(key, subscriber);
            }

            return false;
        }

        private bool Unsubscribe(int key, object subscriber)
        {
            bool didRemove = false;

            foreach (IWeakDelegate weakDel in _subs[key])
            {
                if (weakDel.Contains(subscriber) && _subs[key].TryRemove(weakDel))
                {
                    didRemove = true;
                }
            }

            return didRemove;
        }

        #endregion Unsubscribe

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ConcurrentHashSet<IWeakDelegate> GetSubscriberSet<T>()
        {
            int key = GetKey<T>();

            return GetSubscriberSet(key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ConcurrentHashSet<IWeakDelegate> GetSubscriberSet(int key)
        {
            _subs.TryGetValue(key, out ConcurrentHashSet<IWeakDelegate> subsSet);

            if (subsSet == null)
            {
                subsSet = new ConcurrentHashSet<IWeakDelegate>();
                _subs.TryAdd(key, subsSet);
            }

            return subsSet;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int GetKey<T>() => typeof(T).GetHashCode();
    }
}