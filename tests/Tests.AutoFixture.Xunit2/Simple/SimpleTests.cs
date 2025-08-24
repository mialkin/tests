using AutoFixture.Xunit2;
using Shouldly;
using Tests.AutoFixture.Xunit2.Infrastructure.Dtos;

namespace Tests.AutoFixture.Xunit2.Simple;

public class SimpleTests
{
    [Theory]
    [InlineData("one")]
    public void InlineData(string value)
    {
        value.ShouldBe("one");
    }

    [Theory]
    [AutoData]
    public void AutoData(string value)
    {
        value.ShouldNotBeNullOrEmpty(value);
    }

    [Theory]
    [AutoData]
    public void Dto(UserDto dto)
    {
        dto.Id.ShouldBeGreaterThan(Guid.Empty);
        dto.Username.ShouldNotBeEmpty();
        dto.CreatedOn.ShouldBeGreaterThan(DateTime.MinValue);
    }
}
