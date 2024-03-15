using Microsoft.Extensions.Logging;

namespace Tests.TestLogs.Infrastructure;

public class Service : IService
{
    private readonly ILogger<Service> _logger;

    public Service(ILogger<Service> logger)
    {
        _logger = logger;
    }

    public void DoJob(int number)
    {
        if (number > 10)
        {
            _logger.LogError("Error creating a user. Operation failed");

            return;
        }

        _logger.LogInformation("Operation succeeded");
    }
}
