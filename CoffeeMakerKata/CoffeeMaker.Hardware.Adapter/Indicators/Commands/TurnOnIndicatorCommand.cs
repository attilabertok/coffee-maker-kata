using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Indicators.Commands;

public class TurnOnIndicatorCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public TurnOnIndicatorCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetIndicatorState(IndicatorState.On);
    }
}
