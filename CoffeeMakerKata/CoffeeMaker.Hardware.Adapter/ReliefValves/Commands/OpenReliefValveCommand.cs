using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.ReliefValves.Commands;

public class OpenReliefValveCommand : ICommand
{
    private readonly ICoffeeMakerApi api;

    public OpenReliefValveCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public void Execute()
    {
        api.SetReliefValveState(ReliefValveState.Open);
    }
}
