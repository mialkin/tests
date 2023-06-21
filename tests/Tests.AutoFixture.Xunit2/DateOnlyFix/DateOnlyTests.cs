using FluentAssertions;

namespace Tests.AutoFixture.Xunit2.DateOnlyFix;

public class DateOnlyTests
{
    [Theory]
    [DateOnlyAutoData]
    public void DateOnlyFix(ClientDto dto)
    {
        dto.Day.Should().BeAfter(DateOnly.MinValue);
    }
}