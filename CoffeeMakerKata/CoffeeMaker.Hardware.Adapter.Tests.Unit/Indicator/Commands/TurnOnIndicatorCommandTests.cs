using CoffeeMaker.Hardware.Adapter.Indicator.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Indicator.Commands;

public partial class TurnOnIndicatorCommandTests
{
    private readonly TurnOnIndicatorCommand sut;
    private IndicatorState indicatorState;

    public TurnOnIndicatorCommandTests()
    {
        indicatorState = IndicatorState.Off;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetIndicatorState(Arg.Any<IndicatorState>()))
            .Do(x => indicatorState = x.Arg<IndicatorState>());

        sut = new TurnOnIndicatorCommand(mockApi);
    }
}
