using AutoFixture;
using AutoFixture.Kernel;
using AutoFixture.Xunit3;
using Moq;
using Shouldly;
using Tests.AutoFixture.AutoMoq.Complex.Domain;
using Tests.AutoFixture.AutoMoq.Services;
using Xunit;

namespace Tests.AutoFixture.AutoMoq.Complex;

public class ComplexSutTests
{
    [Fact]
    public void Calculate_ReturnsValidResult()
    {
        var fixture = new Fixture();
        fixture.Customizations.Add(new TypeRelay(typeof(ICustomService), typeof(CustomService)));
        var sut = fixture.Create<ComplexSut>();

        var result = sut.Calculate();
        result.ShouldBe(15);
    }

    [Theory]
    [AutoDomainData]
    public void Calculate_WithAutoDomainData_ReturnsValidResult(ComplexSut sut)
    {
        var result = sut.Calculate();
        result.ShouldBe(5);
    }

    [Theory]
    [AutoDomainData]
    public void Calculate_WithAutoDomainData_ReturnsZero(IComplexSut sut)
    {
        var result = sut.Calculate();
        result.ShouldBe(0);
    }

    [Theory]
    [InlineAutoDomainData(10, 15)]
    [InlineAutoDomainData(1, 6)]
    public void Calculate_WithInlineAutoDomainData_ReturnsValidResult(
        int input,
        int expectedResult,
        [Frozen] Mock<ICustomService> customServiceMock,
        ComplexSut sut)
    {
        customServiceMock
            .Setup(x => x.DoWork())
            .Returns(input);

        var result = sut.Calculate();
        result.ShouldBe(expectedResult);
    }
}
