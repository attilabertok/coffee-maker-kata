using CoffeeMaker.Hardware.Adapter.BrewButtons.Queries;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.BrewButton.Queries;

public partial class BrewButtonStatusQueryTests
{
    private readonly BrewButtonStatusQuery sut;
    private readonly ICoffeeMakerApi mockApi;

    public BrewButtonStatusQueryTests()
    {
        mockApi = Substitute.For<ICoffeeMakerApi>();
        sut = new BrewButtonStatusQuery(mockApi);
    }
}
