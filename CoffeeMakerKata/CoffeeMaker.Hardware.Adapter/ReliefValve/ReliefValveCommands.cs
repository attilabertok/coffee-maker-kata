using CoffeeMaker.Api.Commands;
using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.ReliefValve.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.ReliefValve;

public class ReliefValveCommands : IReliefValveCommands
{
    public ReliefValveCommands(ICoffeeMakerApi api)
    {
        Open = new OpenReliefValveCommand(api);
        Close = new CloseReliefValveCommand(api);
    }

    public ICommand Open { get; }

    public ICommand Close { get; }
}
