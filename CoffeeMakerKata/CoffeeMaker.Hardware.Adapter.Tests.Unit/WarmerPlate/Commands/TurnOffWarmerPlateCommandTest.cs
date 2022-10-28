using CoffeeMaker.Hardware.Adapter.WarmerPlate.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Commands;

public partial class TurnOffWarmerPlateCommandTest
{
    private readonly TurnOffWarmerPlateCommand sut;
    private WarmerPlateState warmerPlateState;

    public TurnOffWarmerPlateCommandTest()
    {
        warmerPlateState = WarmerPlateState.On;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetWarmerState(Arg.Any<WarmerPlateState>()))
            .Do(x => warmerPlateState = x.Arg<WarmerPlateState>());

        sut = new TurnOffWarmerPlateCommand(mockApi);
    }
}
