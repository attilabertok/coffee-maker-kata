using CoffeeMaker.Api.Commands;
using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlate;

public class WarmerPlateCommands : IWarmerPlateCommands
{
    public WarmerPlateCommands(ICoffeeMakerApi api)
    {
        TurnOn = new TurnOnWarmerPlateCommand(api);
        TurnOff = new TurnOffWarmerPlateCommand(api);
    }

    public ICommand TurnOn { get; }

    public ICommand TurnOff { get; }
}
