using AutoFixture.Xunit2;
using FluentAssertions;
using Tests.AutoFixture.Xunit2.Infrastructure.Dtos;

namespace Tests.AutoFixture.Xunit2.Simple;

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
    
    [Theory]
    [AutoData]
    public void Dto(UserDto dto)
    {
        dto.Id.Should().NotBeEmpty();
        dto.Username.Should().NotBeEmpty();
        dto.CreatedOn.Should().BeAfter(DateTime.MinValue);
    }
}