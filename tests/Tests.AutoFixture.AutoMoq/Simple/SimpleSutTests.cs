using AutoFixture.Xunit3;
using Shouldly;
using Tests.AutoFixture.AutoMoq.Simple.Domain;

namespace Tests.AutoFixture.AutoMoq.Simple;

public class SimpleSutTests
{
    [Theory]
    [AutoData]
    public void Calculate_ReturnsValidResult(SimpleSut sut)
    {
        var result = sut.Calculate();
        result.ShouldBe(5);
    }
}
