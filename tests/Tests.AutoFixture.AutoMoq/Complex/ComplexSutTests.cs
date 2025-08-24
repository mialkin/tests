using AutoFixture;
using AutoFixture.Kernel;
using Shouldly;
using Tests.AutoFixture.AutoMoq.Complex.Domain;
using Tests.AutoFixture.AutoMoq.Services;

namespace Tests.AutoFixture.AutoMoq.Complex;

public class ComplexSutTests
{
    // Will not work because of an error:
    // AutoFixture was unable to create an instance from Tests.AutoFixture.AutoMoq.Services.ICustomService because it's an interface.
    /*

    [Theory]
    [AutoData]
    public void Calculate_WillNotWork(ComplexSut sut)
    {
        var result = sut.Calculate();
        result.Should().Be(15);
    }

    */

    [Fact]
    public void Calculate_ReturnsValidResult()
    {
        var fixture = new Fixture();
        fixture.Customizations.Add(new TypeRelay(typeof(ICustomService), typeof(CustomService)));
        var sut = fixture.Create<ComplexSut>();

        var result = sut.Calculate();
        result.ShouldBe(15);
    }

    [Fact]
    public void Calculate_WithAutoDomainData_ReturnsValidResult()
    {
        var fixture = new Fixture();
        fixture.Customizations.Add(new TypeRelay(typeof(ICustomService), typeof(CustomService)));
        var sut = fixture.Create<ComplexSut>();

        var result = sut.Calculate();
        result.ShouldBe(15);
    }
}
