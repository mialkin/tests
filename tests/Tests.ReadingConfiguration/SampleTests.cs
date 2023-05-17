using FluentAssertions;
using Tests.ReadingConfiguration.ExtensionMethods;

namespace Tests.ReadingConfiguration;

public class SampleTests
{
    [Fact]
    public void BaseAddress_IsNotNullOrWhitespace()
    {
        var baseAddress =
            Configuration.Root.GetRequiredSection<SampleClientSettings>().BaseAddress;

        baseAddress.Should().NotBeNullOrWhiteSpace(baseAddress);
    }
}