using CoffeeMaker.Hardware.Adapter.Boilers.Queries;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Queries;

public partial class BoilerStatusQueryTests
{
    private readonly BoilerStatusQuery sut;
    private readonly ICoffeeMakerApi mockApi;

    public BoilerStatusQueryTests()
    {
        mockApi = Substitute.For<ICoffeeMakerApi>();
        sut = new BoilerStatusQuery(mockApi);
    }
}
