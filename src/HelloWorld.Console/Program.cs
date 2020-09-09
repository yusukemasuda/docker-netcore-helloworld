namespace HelloWorld.Console
{
    using HelloWorld.Core;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IHelloWorldService, HelloWorldService>();

            var provider = services.BuildServiceProvider();

            var service = provider.GetService<IHelloWorldService>();
            var message = service.SayHello("World");
            Console.WriteLine(message);
        }
    }
}
