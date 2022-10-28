using CoffeeMaker.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.ReliefValve.Commands;

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
