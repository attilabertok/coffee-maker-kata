using CoffeeMaker.Hardware.Adapter.Indicator.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Indicator.Commands;

public partial class SignalErrorCommandTests
{
    private readonly SignalErrorCommand sut;
    private IndicatorState indicatorState;
    private int indicatorFlashCount;

    public SignalErrorCommandTests()
    {
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetIndicatorState(Arg.Any<IndicatorState>()))
            .Do(x => indicatorState = x.Arg<IndicatorState>());
        mockApi.When(a => a.SetIndicatorState(Arg.Is(IndicatorState.On)))
            .Do(_ => indicatorFlashCount++);

        sut = new SignalErrorCommand(mockApi);
    }
}
