﻿using System;
using System.Collections.Generic;
using System.Text;

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

        /// <summary>
        /// Listen for some type of data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listener">The method to be executed when data of type T is published.</param>
        /// <returns></returns>
        bool Subscribe<T>(Action<T> listener);
    }
}
