using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlate.Commands;

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
