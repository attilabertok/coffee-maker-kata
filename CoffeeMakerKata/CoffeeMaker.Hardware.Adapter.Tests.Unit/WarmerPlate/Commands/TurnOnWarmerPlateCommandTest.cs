using CoffeeMaker.Hardware.Adapter.WarmerPlates.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Commands;

public partial class TurnOnWarmerPlateCommandTest
{
    private readonly TurnOnWarmerPlateCommand sut;
    private WarmerPlateState warmerPlateState;

    public TurnOnWarmerPlateCommandTest()
    {
        warmerPlateState = WarmerPlateState.Off;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetWarmerState(Arg.Any<WarmerPlateState>()))
            .Do(x => warmerPlateState = x.Arg<WarmerPlateState>());

        sut = new TurnOnWarmerPlateCommand(mockApi);
    }
}
