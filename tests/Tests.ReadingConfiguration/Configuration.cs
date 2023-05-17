using System;
using Microsoft.Extensions.Configuration;

namespace Tests.ReadingConfiguration;

internal static class Configuration
{
    static Configuration()
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? HostEnvironment.Ide;
        Root = new ConfigurationBuilder().AddJsonFile($"appsettings.{environment}.json").Build();
    }

    public static IConfiguration Root { get; }
}
