using CoffeeMaker.Core.Api.Commands;
using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlates.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlates;

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
