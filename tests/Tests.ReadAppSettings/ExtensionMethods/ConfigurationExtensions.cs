using Microsoft.Extensions.Configuration;

namespace Tests.ReadAppSettings.ExtensionMethods;

public static class ConfigurationExtensions
{
    public static T? GetRequiredSection<T>(this IConfiguration configuration) =>
        configuration.GetRequiredSection(typeof(T).Name).Get<T>();
}