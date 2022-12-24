namespace Localization_Service_Application.Common.Behaviours.LoggingBehaviour;

public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest> where TRequest : notnull
{
    private readonly ILogger logger;
    public LoggingBehaviour(ILogger logger)
    {
        this.logger = logger;
    }
    public async Task Process(TRequest request, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;


        logger.LogInformation("CleanArchitecture Request: {Name}  {@Request}",
            requestName, request);
    }
}
