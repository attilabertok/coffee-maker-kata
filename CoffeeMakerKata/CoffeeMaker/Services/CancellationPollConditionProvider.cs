namespace CoffeeMaker.Services;

public class CancellationPollConditionProvider : IPollConditionProvider
{
    public CancellationPollConditionProvider(CancellationToken cancellationToken)
    {
        PollCondition = () => !cancellationToken.IsCancellationRequested;
    }

    public Func<bool> PollCondition { get; }
}
