using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Boiler.Commands;

public class TurnOffBoilerCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public TurnOffBoilerCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetBoilerState(BoilerState.Off);
    }
}
