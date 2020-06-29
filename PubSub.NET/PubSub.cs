using PubSubNET.Core;
using System;

namespace PubSubNET
{
    public static class PubSub
    {
        private static IEventHub _eventHubImpl;

        private static IEventHub _hub => _eventHubImpl ??= new EventHub();

        public static bool RegisterEventHubImplementation(IEventHub hub)
        {
            if (_eventHubImpl == null)
            {
                _eventHubImpl = hub;
                return true;
            }

            return false;
        }

        #region Publish
        public static void Publish<T>(T data) => _hub.Publish(data);

        public static void Publish<T1, T2>(T1 data1, T2 data2) => _hub.Publish(data1, data2);

        public static void Publish<T1, T2, T3>(T1 data1, T2 data2, T3 data3) => _hub.Publish(data1, data2, data3);

        public static void Publish<T1, T2, T3, T4>(T1 data1, T2 data2, T3 data3, T4 data4) => _hub.Publish(data1,
                                                                                                           data2,
                                                                                                           data3,
                                                                                                           data4);

        public static void Publish<T1, T2, T3, T4, T5>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5) => _hub.Publish(data1,
                                                                                                                         data2,
                                                                                                                         data3,
                                                                                                                         data4,
                                                                                                                         data5);

        public static void Publish<T1, T2, T3, T4, T5, T6>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6) => _hub.Publish(data1,
                                                                                                                                       data2,
                                                                                                                                       data3,
                                                                                                                                       data4,
                                                                                                                                       data5,
                                                                                                                                       data6);

        public static void Publish<T1, T2, T3, T4, T5, T6, T7>(T1 data1,
                                                               T2 data2,
                                                               T3 data3,
                                                               T4 data4,
                                                               T5 data5,
                                                               T6 data6,
                                                               T7 data7) => _hub.Publish(data1,
                                                                                         data2,
                                                                                         data3,
                                                                                         data4,
                                                                                         data5,
                                                                                         data6,
                                                                                         data7);

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8>(T1 data1,
                                                                   T2 data2,
                                                                   T3 data3,
                                                                   T4 data4,
                                                                   T5 data5,
                                                                   T6 data6,
                                                                   T7 data7,
                                                                   T8 data8) => _hub.Publish(data1,
                                                                                             data2,
                                                                                             data3,
                                                                                             data4,
                                                                                             data5,
                                                                                             data6,
                                                                                             data7,
                                                                                             data8);

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 data1,
                                                                       T2 data2,
                                                                       T3 data3,
                                                                       T4 data4,
                                                                       T5 data5,
                                                                       T6 data6,
                                                                       T7 data7,
                                                                       T8 data8,
                                                                       T9 data9) => _hub.Publish(data1,
                                                                                                 data2,
                                                                                                 data3,
                                                                                                 data4,
                                                                                                 data5,
                                                                                                 data6,
                                                                                                 data7,
                                                                                                 data8,
                                                                                                 data9);

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 data1,
                                                                            T2 data2,
                                                                            T3 data3,
                                                                            T4 data4,
                                                                            T5 data5,
                                                                            T6 data6,
                                                                            T7 data7,
                                                                            T8 data8,
                                                                            T9 data9,
                                                                            T10 data10) => _hub.Publish(data1,
                                                                                                        data2,
                                                                                                        data3,
                                                                                                        data4,
                                                                                                        data5,
                                                                                                        data6,
                                                                                                        data7,
                                                                                                        data8,
                                                                                                        data9,
                                                                                                        data10);

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 data1,
                                                                                 T2 data2,
                                                                                 T3 data3,
                                                                                 T4 data4,
                                                                                 T5 data5,
                                                                                 T6 data6,
                                                                                 T7 data7,
                                                                                 T8 data8,
                                                                                 T9 data9,
                                                                                 T10 data10,
                                                                                 T11 data11) => _hub.Publish(data1,
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

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 data1,
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
                                                                                      T12 data12) => _hub.Publish(data1,
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

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 data1,
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
                                                                                           T13 data13) => _hub.Publish(data1,
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

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 data1,
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
                                                                                                T14 data14) => _hub.Publish(data1,
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

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 data1,
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
                                                                                                     T15 data15) => _hub.Publish(data1,
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

        public static void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 data1,
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
                                                                                                          T16 data16) => _hub.Publish(data1,
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

        #endregion

        #region Subscribe

        public static bool Subscribe<TSub, T1>(TSub subscriber, Action<T1> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2>(TSub subscriber, Action<T1, T2> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3>(TSub subscriber, Action<T1, T2, T3> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4>(TSub subscriber, Action<T1, T2, T3, T4> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5>(TSub subscriber, Action<T1, T2, T3, T4, T5> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        public static bool Subscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TSub subscriber, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener) where TSub : class => _hub.Subscribe(subscriber, listener);

        #endregion

        #region Unsubscribe

        public static bool Unsubscribe<TSub, T1>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(subscriber);

        public static bool Unsubscribe<TSub, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(TSub subscriber) where TSub : class => _hub.Unsubscribe<TSub, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(subscriber);
        #endregion
    }
}
