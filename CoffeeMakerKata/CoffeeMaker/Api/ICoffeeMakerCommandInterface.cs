using CoffeeMaker.Api.Commands;

namespace CoffeeMaker.Api;

public interface ICoffeeMakerCommandInterface
{
    IBoilerCommands Boiler { get; }

    IIndicatorCommands Indicator { get; }

    IReliefValveCommands ReliefValve { get; }

    IWarmerPlateCommands WarmerPlate { get; }
}
