using CoffeeMaker.Api.Commands.Base;

namespace CoffeeMaker.Api.Commands;

public interface IWarmerPlateCommands
{
    ICommand TurnOn { get; }

    ICommand TurnOff { get; }
}
