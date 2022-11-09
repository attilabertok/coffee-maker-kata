using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.ReliefValves.Commands;

public class CloseReliefValveCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public CloseReliefValveCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetReliefValveState(ReliefValveState.Closed);
    }
}
