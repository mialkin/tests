using AutoFixture;
using Shouldly;
using Tests.AutoFixture.Xunit2.Infrastructure.Dtos;

namespace Tests.AutoFixture.Xunit2.DateOnlyFix;

public class DateOnlyTests
{
    [Theory]
    [DateOnlyAutoData]
    public void DateOnlyFix(ClientDto dto)
    {
        dto.Day.ShouldBeGreaterThan(DateOnly.MinValue);
    }

    [Fact]
    public void DateOnlyWithFixture()
    {
        var fixture = DateOnlyFixFixture.Create();
        var dateOnly = fixture.Create<DateOnly>(); // Now works

        dateOnly.ShouldBeGreaterThan(DateOnly.MinValue);
    }

    [Fact]
    public void DateOnlyWillNotWork()
    {
        var fixture = new Fixture();

        // Won't work:
        // var dateOnly = fixture.Create<DateOnly>();
    }
}
