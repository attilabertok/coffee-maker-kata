using CoffeeMaker.Core.Api.Commands;

namespace CoffeeMaker.Core.Entities.ReliefValves;

public class ReliefValve : IReliefValve
{
    private readonly IReliefValveCommands reliefValveCommands;

    public ReliefValve(IReliefValveCommands reliefValveCommands)
    {
        this.reliefValveCommands = reliefValveCommands;
    }

    public void Open()
    {
        reliefValveCommands.Open.Execute();
    }

    public void Close()
    {
        reliefValveCommands.Close.Execute();
    }
}
