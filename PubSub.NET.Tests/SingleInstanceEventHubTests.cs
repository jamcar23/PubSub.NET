using System;
using System.Collections.Generic;
using System.Text;
using PubSubNET.Core;

namespace PubSubNET.Tests
{
    public class SingleInstanceEventHubTests : EventHubTests
    {
        private readonly IEventHub _instance = new EventHub();

        protected override IEventHub EventHub => _instance;
    }
}
