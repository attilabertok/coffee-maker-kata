using CoffeeMaker.Api.Commands;
using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.Boiler.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Boiler;

public class BoilerCommands : IBoilerCommands
{
    public BoilerCommands(ICoffeeMakerApi api)
    {
        TurnOn = new TurnOnBoilerCommand(api);
        TurnOff = new TurnOffBoilerCommand(api);
    }

    public ICommand TurnOn { get; }

    public ICommand TurnOff { get; }
}
