using CoffeeMaker.Services;

namespace CoffeeMaker.Tests.Unit.Services;

public partial class CancellationPollConditionProviderTests
{
    private readonly CancellationPollConditionProvider sut;
    private readonly CancellationTokenSource cancellationTokenSource;

    public CancellationPollConditionProviderTests()
    {
        cancellationTokenSource = new CancellationTokenSource();
        sut = new CancellationPollConditionProvider(cancellationTokenSource.Token);
    }
}
