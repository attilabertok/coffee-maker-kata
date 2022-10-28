using CoffeeMaker.Api;
using CoffeeMaker.Api.Commands;
using CoffeeMaker.Hardware.Adapter.Boiler;
using CoffeeMaker.Hardware.Adapter.Indicator;
using CoffeeMaker.Hardware.Adapter.ReliefValve;
using CoffeeMaker.Hardware.Adapter.WarmerPlate;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter;

public class CoffeeMakerCommandInterface : ICoffeeMakerCommandInterface
{
    public CoffeeMakerCommandInterface(ICoffeeMakerApi api)
    {
        Boiler = new BoilerCommands(api);
        Indicator = new IndicatorCommands(api);
        ReliefValve = new ReliefValveCommands(api);
        WarmerPlate = new WarmerPlateCommands(api);
    }

    public IBoilerCommands Boiler { get; }

    public IIndicatorCommands Indicator { get; }

    public IReliefValveCommands ReliefValve { get; }

    public IWarmerPlateCommands WarmerPlate { get; }
}
