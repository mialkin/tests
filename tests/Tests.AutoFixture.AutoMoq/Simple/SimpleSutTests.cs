using AutoFixture.Xunit2;
using FluentAssertions;
using Tests.AutoFixture.AutoMoq.Simple.Domain;

namespace Tests.AutoFixture.AutoMoq.Simple;

public class SimpleSutTests
{
    [Theory]
    [AutoData]
    public void Calculate_ReturnsValidResult(SimpleSut sut)
    {
        var result = sut.Calculate();
        result.Should().Be(5);
    }
}