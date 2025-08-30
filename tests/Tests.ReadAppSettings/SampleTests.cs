using Shouldly;
using Tests.ReadAppSettings.ExtensionMethods;
using Xunit;

namespace Tests.ReadAppSettings;

public class SampleTests
{
    [Fact]
    public void BaseAddress_IsNotNullOrWhitespace()
    {
        var baseAddress = Configuration.Root.GetRequiredSection<SampleClientSettings>()?.BaseAddress;

        baseAddress.ShouldNotBeNullOrWhiteSpace(baseAddress);
    }
}
