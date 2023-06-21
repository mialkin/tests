using AutoFixture.Xunit2;
using FluentAssertions;

namespace Tests.AutoFixture.Xunit2;

public class SimpleTests
{
    [Theory]
    [InlineData("one")]
    public void InlineData(string value)
    {
        value.Should().Be("one");
    }

    [Theory]
    [AutoData]
    public void AutoData(string value)
    {
        value.Should().NotBeNullOrEmpty(value);
    }
}