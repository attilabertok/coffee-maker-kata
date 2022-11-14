using CoffeeMaker.Core.Interactors;

namespace CoffeeMaker.Core.Tests.Unit.Interactors;

public partial class CanKeepWarmInteractorTests
{
    private readonly ICanKeepWarmInteractor sut;

    public CanKeepWarmInteractorTests()
    {
        sut = new CanKeepWarmInteractor();
    }
}
