using CoffeeMaker.Core.Api.Commands;

namespace CoffeeMaker.Core.Entities.Indicators;

public class Indicator : IIndicator
{
    private readonly IIndicatorCommands indicatorCommands;

    public Indicator(IIndicatorCommands indicatorCommands)
    {
        this.indicatorCommands = indicatorCommands;
    }

    public async Task SignalError()
    {
        await indicatorCommands.SignalError.ExecuteAsync();
    }

    public void TurnOn()
    {
        indicatorCommands.TurnOn.Execute();
    }

    public void TurnOff()
    {
        indicatorCommands.TurnOff.Execute();
    }
}
