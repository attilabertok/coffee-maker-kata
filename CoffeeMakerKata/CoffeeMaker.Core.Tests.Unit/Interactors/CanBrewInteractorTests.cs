using CoffeeMaker.Core.Interactors;

namespace CoffeeMaker.Core.Tests.Unit.Interactors;

public partial class CanBrewInteractorTests
{
    private readonly ICanBrewInteractor sut;

    public CanBrewInteractorTests()
    {
        sut = new CanBrewInteractor();
    }
}
