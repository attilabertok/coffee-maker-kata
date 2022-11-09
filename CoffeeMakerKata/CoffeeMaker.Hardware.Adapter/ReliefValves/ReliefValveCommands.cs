using CoffeeMaker.Core.Api.Commands;
using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.ReliefValves.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.ReliefValves;

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
