using AutoFixture.Xunit3;
using Shouldly;
using Tests.AutoFixture.Xunit3.Infrastructure.Dtos;
using Xunit;

namespace Tests.AutoFixture.Xunit3.Simple;

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
