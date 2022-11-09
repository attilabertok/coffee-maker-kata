using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlates.Commands;

public class TurnOnWarmerPlateCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public TurnOnWarmerPlateCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetWarmerState(WarmerPlateState.On);
    }
}
