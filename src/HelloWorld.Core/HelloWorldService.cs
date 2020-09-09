namespace HelloWorld.Core
{
    using System;

    public class HelloWorldService : IHelloWorldService
    {
        public string SayHello(string name)
        {
            return string.Format("Hello, {0}.", name);
        }
    }
}
