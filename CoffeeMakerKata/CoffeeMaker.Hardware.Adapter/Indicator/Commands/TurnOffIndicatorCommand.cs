using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Indicator.Commands;

public class TurnOffIndicatorCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public TurnOffIndicatorCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetIndicatorState(IndicatorState.Off);
    }
}
