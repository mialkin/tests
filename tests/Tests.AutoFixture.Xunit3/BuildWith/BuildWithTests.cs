using AutoFixture;
using Shouldly;
using Tests.AutoFixture.Xunit3.Infrastructure.Dtos;
using Xunit;

namespace Tests.AutoFixture.Xunit3.BuildWith;

public class BuildWithTests
{
    private const string Username = "john.doe";

    [Fact]
    public void BuildWith_WhenPropertyIsSpecified_ReturnsInstanceWithThatProperty()
    {
        // Arrange
        var fixture = new Fixture();

        var user = fixture
            .Build<UserDto>()
            .With(x => x.Username, Username)
            .Create();

        // Assert
        user.Username.ShouldBe(Username);
    }

    [Fact]
    public void BuildWith_WhenPropertyIsNotSpecified_ReturnsInstanceWithoutThatProperty()
    {
        // Arrange
        var fixture = new Fixture();

        var user = fixture
            .Build<UserDto>()
            .Create();

        // Assert
        user.Username.ShouldNotBe(Username);
    }
}
