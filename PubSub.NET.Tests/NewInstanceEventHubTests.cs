using System;
using System.Collections.Generic;
using System.Text;
using PubSubNET.Core;

namespace PubSubNET.Tests
{
    public class NewInstanceEventHubTests : EventHubTests
    {
        protected override IEventHub EventHub => new EventHub();
    }
}
