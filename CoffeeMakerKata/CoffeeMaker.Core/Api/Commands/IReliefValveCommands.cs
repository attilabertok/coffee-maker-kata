using CoffeeMaker.Core.Api.Commands.Base;

namespace CoffeeMaker.Core.Api.Commands;

public interface IReliefValveCommands
{
    ICommand Open { get; }

    ICommand Close { get; }
}
