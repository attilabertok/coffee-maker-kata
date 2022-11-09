using CoffeeMaker.Core.Api.Commands.Base;

namespace CoffeeMaker.Core.Api.Commands;

public interface IWarmerPlateCommands
{
    ICommand TurnOn { get; }

    ICommand TurnOff { get; }
}
