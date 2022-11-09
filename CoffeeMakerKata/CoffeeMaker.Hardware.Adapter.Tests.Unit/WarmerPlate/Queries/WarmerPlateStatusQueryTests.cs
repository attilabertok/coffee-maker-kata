using CoffeeMaker.Hardware.Adapter.WarmerPlates.Queries;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Queries;

public partial class WarmerPlateStatusQueryTests
{
    private readonly WarmerPlateStatusQuery sut;
    private readonly ICoffeeMakerApi mockApi;

    public WarmerPlateStatusQueryTests()
    {
        mockApi = Substitute.For<ICoffeeMakerApi>();
        sut = new WarmerPlateStatusQuery(mockApi);
    }
}
