using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlate.Commands;

public class TurnOffWarmerPlateCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public TurnOffWarmerPlateCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetWarmerState(WarmerPlateState.Off);
    }
}
