using CoffeeMaker.Api.Commands.Base;

namespace CoffeeMaker.Api.Commands;

public interface IIndicatorCommands
{
    IAsyncCommand SignalError { get; }

    ICommand TurnOn { get; }

    ICommand TurnOff { get; }
}
