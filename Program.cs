using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DependencyInjection.Services;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Sets up a default host builder in a .net6 application
        // Host is now set up with configured services or unconfigured service
        IHost _host = Host.CreateDefaultBuilder().ConfigureServices(
            services => {
                services.AddSingleton < IApplication, Application > ();
        }).Build();

        // Gets access to dependcy injection & require this service
        var app = _host.Services.GetRequiredService<IApplication>();

        // Call the method on the item. On the instantiated object.
        app.Run();
    }
}