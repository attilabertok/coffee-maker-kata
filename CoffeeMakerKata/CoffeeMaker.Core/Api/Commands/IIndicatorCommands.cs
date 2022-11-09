using CoffeeMaker.Core.Api.Commands.Base;

namespace CoffeeMaker.Core.Api.Commands;

public interface IIndicatorCommands
{
    IAsyncCommand SignalError { get; }

    ICommand TurnOn { get; }

    ICommand TurnOff { get; }
}
