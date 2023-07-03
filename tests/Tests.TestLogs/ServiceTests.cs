using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Tests.TestLogs.Infrastructure;

namespace Tests.TestLogs;

public class ServiceTests
{
    [Fact]
    public void DoJob_WhenNumberIsGreaterThanTen_WriteErrorLog()
    {
        // Arrange
        var loggerMock = new Mock<ILogger<Service>>();
        var sut = new Service(loggerMock.Object);

        loggerMock.Setup(x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()
            )
        );

        // Act
        sut.DoJob(number: 15);

        // Assert
        const int logLevelIndex = 0;
        const int logMessagesIndex = 2;

        var loggedMessages = loggerMock.Invocations
            .Where(x => (LogLevel) x.Arguments[logLevelIndex] == LogLevel.Error)
            .Select(x => x.Arguments[logMessagesIndex].ToString());

        loggedMessages.Should()
            .ContainMatch("Error creating a user. *");
    }

    [Fact]
    public void DoJob_WhenNumberIsLessOrEqualThanTen_WriteInfoLog()
    {
        // Arrange
        var loggerMock = new Mock<ILogger<Service>>();
        var sut = new Service(loggerMock.Object);

        loggerMock.Setup(x => x.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()
            )
        );

        // Act
        sut.DoJob(number: 5);

        // Assert
        const int logLevelIndex = 0;
        const int logMessagesIndex = 2;

        var loggedMessages = loggerMock.Invocations
            .Where(x => (LogLevel) x.Arguments[logLevelIndex] == LogLevel.Information)
            .Select(x => x.Arguments[logMessagesIndex].ToString());

        loggedMessages.Should()
            .ContainMatch("Operation succeeded");
    }
}