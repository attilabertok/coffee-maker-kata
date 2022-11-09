using CoffeeMaker.Hardware.Adapter.Indicators.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Indicator.Commands;

public partial class TurnOffIndicatorCommandTests
{
    private readonly TurnOffIndicatorCommand sut;
    private IndicatorState indicatorState;

    public TurnOffIndicatorCommandTests()
    {
        indicatorState = IndicatorState.On;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetIndicatorState(Arg.Any<IndicatorState>()))
            .Do(x => indicatorState = x.Arg<IndicatorState>());

        sut = new TurnOffIndicatorCommand(mockApi);
    }
}
