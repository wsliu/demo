using System;
using GreetingMessage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGreetingMessage
{
    [TestClass]
    public class TestGreetMessage
    {
        [TestMethod]
        public void should_return_hello_as_default_greeting_message()
        {
            var message = new SimpleGreeting();
            Assert.AreEqual("Hello!", message.GetMessage());
        }
    }
}
