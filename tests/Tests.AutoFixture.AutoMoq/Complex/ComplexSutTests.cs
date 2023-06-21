using AutoFixture;
using AutoFixture.Kernel;
using FluentAssertions;
using Tests.AutoFixture.AutoMoq.Complex.Domain;
using Tests.AutoFixture.AutoMoq.Services;

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
        result.Should().Be(15);
    }
}