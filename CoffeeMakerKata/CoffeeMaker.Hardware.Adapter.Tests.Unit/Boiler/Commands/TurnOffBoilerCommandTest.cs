using CoffeeMaker.Hardware.Adapter.Boilers.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Commands;

public partial class TurnOffBoilerCommandTest
{
    private readonly TurnOffBoilerCommand sut;
    private BoilerState boilerState;

    public TurnOffBoilerCommandTest()
    {
        boilerState = BoilerState.On;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetBoilerState(Arg.Any<BoilerState>()))
            .Do(x => boilerState = x.Arg<BoilerState>());

        sut = new TurnOffBoilerCommand(mockApi);
    }
}
