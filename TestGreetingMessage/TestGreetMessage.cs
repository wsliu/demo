using System;
using GreetingMessage;
using NUnit.Framework;


namespace TestGreetingMessage
{
    [TestFixture]
    public class TestGreetMessage
    {
        [Test]
        public void should_return_hello_as_default_greeting_message()
        {
            var message = new SimpleGreeting();
            Assert.AreEqual("Hello!", message.GetMessage());
        }
    }
}
