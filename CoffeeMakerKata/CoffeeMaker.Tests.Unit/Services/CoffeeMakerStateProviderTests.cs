using CoffeeMaker.Services;

namespace CoffeeMaker.Tests.Unit.Services;

public partial class CoffeeMakerStateProviderTests
{
    private readonly ICoffeeMakerStateProvider sut;

    public CoffeeMakerStateProviderTests()
    {
        sut = new CoffeeMakerStateProvider();
    }
}
