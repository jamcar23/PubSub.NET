using PubSub.NET.Core;
using System;

namespace PubSub.NET
{
    public static class PubSub
    {
        private static IEventHub _eventHubImpl;

        private static IEventHub _hub => _eventHubImpl ??= new EventHub();

        public static bool RegisterEventHubImplementation(IEventHub hub)
        {
            if(_eventHubImpl == null)
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

        public static bool Subscribe<T>(Action<T> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2>(Action<T1, T2> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3>(Action<T1, T2, T3> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4>(Action<T1, T2, T3, T4> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener) => _hub.Subscribe(listener);

        public static bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener) => _hub.Subscribe(listener);

        #endregion

        #region Unsubscribe

        public static bool Unsubscribe<T>(Action<T> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2>(Action<T1, T2> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3>(Action<T1, T2, T3> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4>(Action<T1, T2, T3, T4> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener) => _hub.Unsubscribe(listener);

        public static bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener) => _hub.Unsubscribe(listener);
        #endregion
    }
}
