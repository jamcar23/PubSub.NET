# PubSub.NET

A lightweight publisher/subscriber (pub/sub) library for plain old C# objects. This library helps implement the [Pub/Sub](https://jamescarroll.xyz/post/observer-vs-pubsub/) design pattern for passing messages between loosely coupled objects. (This is some times known as an event aggregator or message center.)

The primary use case for this library is when you want object A & B to communicate with each other without either knowing of the others existence. Examples: 
- communicating between Activities and Fragments in Android
- communicating between services
- communicating between ViewModels
- communicating between MonoBehaviours
- etc.

## Usage

The basic idea is that one or more objects subscribe to the datatype(s) they want (this is similar to listening to an event) while one or more objects publishes the same datatype(s) (this is similar to invoking an event.)

In the following examples `using PubSubNET;` must be added to the top of the files.

### Subscribing

Subscribing is mostly the same as listening to an event except that you must pass in a reference to the subscriber, the datatype(s) you're subscribing to, and a method or lambda which accepts those datatype(s). 

The method / lambda you subscribe with must conform to any of the `System.Action<>` delegates, in other words it must be a void method / lambda that takes in 1 to 16 arguments.

Similarly, one object can subscribe to same datatype(s) multiple times by subscribing with different methods.

NOTE: the invocation order of subscribers / methods / lambdas is *not* guaranteed to be in the same order they subscribed in; similarly, the invocation order is *not* guaranteed to the same across multiple publishes.

Method example:

```
public class MySubscriber
{
    public MySubscriber()
    {
        PubSub.Subscribe<MySubscriber, string>(this, LogString);
    }

    private void LogString(string str)
    {
        Console.WriteLine(str);
    }
}
```

Lambda example:

```
public class MySubscriber
{
    public MySubscriber()
    {
        PubSub.Subscribe<MySubscriber, string>(this, str => Console.WriteLine(str));
    }
}
```

### Publishing

Publishing is mostly like invoking an event except that any object can publish any datatype(s). When an object publishes data all methods / lambdas subscribed to the datatype(s) will be invoked. If there are no subscribers then your program keeps running like normal.

NOTE: the published data *must* match the subscriber's datatypes, number of arguments, and their order in order for the subscriber to be invoked.

Example:

```
public class MyOtherClass
{
    public void MyOtherMethod()
    {
        string str = this.ComputeString(); // some other method to create data

        PubSub.Publish(str); // will invoke MySubscriber.LogStream
        PubSub.Publish(str, true) // won't invoke MySubscriber.LogStream because the arguments don't match
    }
}
```

### Unsubscribing

Unsubscribing is similar to removing an event listener. Similarly to subscribing you need the original subscriber as well as the datatype(s) you're subscribed to.

This is mostly optional and only needs to happen if the subscriber is done listening to those datatype(s). You do *not* need to do this to clean up any memory leaks from delegates as PubSub doesn't store the original delegate. 

NOTE: unsubscribing unsubscribes all methods in the subscriber that matches the datatype(s).

Example:

```
public class MySubscriber : IDisposable
{
    public MySubscriber()
    {
        PubSub.Subscribe<MySubscriber, string>(this, LogString);
    }

    private void LogString(string str)
    {
        Console.WriteLine(str);
    }

    public void Dispose()
    {
        PubSub.Unsubscribe<MySubscriber, string>(this);
    }
}
```
