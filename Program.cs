using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SampleAzureFunction.Net;
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureFunctionsWorkerDefaults()
            .ConfigureServices(services =>
            {
                // Register TimerTrigger and other extensions
                //services.AddSingleton<IMyService, MyService>();
                //services.AddAzureFunctionsWorkerService();
            });
}
