using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace SampleAzureFunction.Net.Functions;

public class CronFunction
{
    private readonly ILogger _logger;

    public CronFunction(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<CronFunction>();
    }

    [Function("CronFunction")]
    public void Run([TimerTrigger("1 * * * * *")] TimerInfo myTimer)
    {
        _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        
        if (myTimer.ScheduleStatus is not null)
        {
            _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
        }
    }
}
