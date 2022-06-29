using Microsoft.Extensions.DependencyInjection;
using TradeCategory.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        var provider = services.BuildServiceProvider();
        var app = provider.GetService<IServiceBase>();
        Console.WriteLine("Trade Category!");
        Console.WriteLine("+++++++++++++++++++++++++");
        app.GetData("data/data.txt");
        Console.WriteLine("+++++++++++++++++++++++++");
        Console.WriteLine("Done!");
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IServiceBase, ServiceBase>();
        services.AddScoped<ITradeService, TradeService>();
    }
}