using CoffeeMaker.Hardware.Adapter.Boiler.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Commands;

public partial class TurnOnBoilerCommandTest
{
    private readonly TurnOnBoilerCommand sut;
    private BoilerState boilerState;

    public TurnOnBoilerCommandTest()
    {
        boilerState = BoilerState.Off;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetBoilerState(Arg.Any<BoilerState>()))
            .Do(x => boilerState = x.Arg<BoilerState>());

        sut = new TurnOnBoilerCommand(mockApi);
    }
}
