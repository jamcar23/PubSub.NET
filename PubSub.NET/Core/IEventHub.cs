using System;

namespace PubSub.NET.Core
{
    /// <summary>
    /// Common definition for classes that manage publishing / subscribing to events / data.
    /// </summary>
    public interface IEventHub
    {
        /// <summary>
        /// Publish data to any subscribers.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        void Publish<T>(T data);
        void Publish<T1, T2>(T1 data1, T2 data2);
        void Publish<T1, T2, T3>(T1 data1, T2 data2, T3 data3);
        void Publish<T1, T2, T3, T4>(T1 data1, T2 data2, T3 data3, T4 data4);
        void Publish<T1, T2, T3, T4, T5>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5);
        void Publish<T1, T2, T3, T4, T5, T6>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6);
        void Publish<T1, T2, T3, T4, T5, T6, T7>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13, T14 data14);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13, T14 data14, T15 data15);
        void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5, T6 data6, T7 data7, T8 data8, T9 data9, T10 data10, T11 data11, T12 data12, T13 data13, T14 data14, T15 data15, T16 data16);

        /// <summary>
        /// Listen for some type of data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listener">The method to be executed when data of type T is published.</param>
        /// <returns>Returns true if the listener was added.</returns>
        bool Subscribe<T>(Action<T> listener);

        bool Subscribe<T1, T2>(Action<T1, T2> listener);
        bool Subscribe<T1, T2, T3>(Action<T1, T2, T3> listener);
        bool Subscribe<T1, T2, T3, T4>(Action<T1, T2, T3, T4> listener);
        bool Subscribe<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener);
        bool Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener);

        /// <summary>
        /// Stop listening for some type of data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listener"></param>
        /// <returns>Returns true if the listener was removed.</returns>
        bool Unsubscribe<T>(Action<T> listener);

        bool Unsubscribe<T1, T2>(Action<T1, T2> listener);
        bool Unsubscribe<T1, T2, T3>(Action<T1, T2, T3> listener);
        bool Unsubscribe<T1, T2, T3, T4>(Action<T1, T2, T3, T4> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> listener);
        bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> listener);
    }
}
