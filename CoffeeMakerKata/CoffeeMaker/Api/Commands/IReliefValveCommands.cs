using CoffeeMaker.Api.Commands.Base;

namespace CoffeeMaker.Api.Commands;

public interface IReliefValveCommands
{
    ICommand Open { get; }

    ICommand Close { get; }
}
