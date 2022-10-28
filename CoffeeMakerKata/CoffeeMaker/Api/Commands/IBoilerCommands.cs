using CoffeeMaker.Api.Commands.Base;

namespace CoffeeMaker.Api.Commands;

public interface IBoilerCommands
{
    ICommand TurnOn { get; }

    ICommand TurnOff { get; }
}
