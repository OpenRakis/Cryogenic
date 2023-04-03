namespace Cryogenic;

using Microsoft.Extensions.DependencyInjection;

using Serilog.Events;

using Spice86.Shared.Interfaces;

internal static class Startup {
    public static ServiceProvider StartupInjectedServices()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddLogging();
        ServiceProvider serviceProvider = services.BuildServiceProvider();
        SetLoggingLevel(serviceProvider);
        return serviceProvider;
    }

    private static void SetLoggingLevel(ServiceProvider serviceProvider) {
        ILoggerService? loggerService = serviceProvider.GetService<ILoggerService>();
        if (loggerService is null) {
            return;
        }

        // You can enable logs here.
        bool silencedLogs = true;
        if (silencedLogs)
        {
            loggerService.AreLogsSilenced = true;
        }
    }
}