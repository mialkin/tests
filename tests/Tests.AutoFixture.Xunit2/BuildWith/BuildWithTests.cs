using AutoFixture;
using FluentAssertions;
using Tests.AutoFixture.Xunit2.Infrastructure.Dtos;

namespace Tests.AutoFixture.Xunit2.BuildWith;

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
        user.Username.Should().Be(Username);
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
        user.Username.Should().NotBe(Username);
    }
}
