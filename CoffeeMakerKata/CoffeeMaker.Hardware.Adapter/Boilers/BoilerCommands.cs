using CoffeeMaker.Core.Api.Commands;
using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.Boilers.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Boilers;

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
