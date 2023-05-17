using Microsoft.Extensions.Configuration;

namespace Tests.ReadingConfiguration.ExtensionMethods;

public static class ConfigurationExtensions
{
    public static T GetRequiredSection<T>(this IConfiguration configuration) =>
        configuration.GetRequiredSection(typeof(T).Name).Get<T>();
}