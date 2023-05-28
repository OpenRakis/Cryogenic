namespace Cryogenic;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Spice86.Logging;
using Spice86.Shared.Interfaces;

public static class LoggerServiceInjectionExtensions {
    public static IServiceCollection AddLogging(this IServiceCollection services) {
        services.TryAddSingleton<ILoggerPropertyBag, LoggerPropertyBag>();
        services.TryAddSingleton<ILoggerService, LoggerService>();
        return services;
    }
}