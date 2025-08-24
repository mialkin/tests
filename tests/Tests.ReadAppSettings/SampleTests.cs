using Shouldly;
using Tests.ReadAppSettings.ExtensionMethods;

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
