using CoffeeMaker.Core.Api.Commands;
using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Entities.WarmerPlates;

public class WarmerPlate : IWarmerPlate
{
    private readonly IWarmerPlateCommands warmerPlateCommands;
    private readonly IWarmerPlateQueries warmerPlateQueries;

    public WarmerPlate(IWarmerPlateCommands warmerPlateCommands, IWarmerPlateQueries warmerPlateQueries)
    {
        this.warmerPlateCommands = warmerPlateCommands;
        this.warmerPlateQueries = warmerPlateQueries;
    }

    public WarmerPlateStatus Status => warmerPlateQueries.Status.Execute();

    public void TurnOn()
    {
        warmerPlateCommands.TurnOn.Execute();
    }

    public void TurnOff()
    {
        warmerPlateCommands.TurnOff.Execute();
    }
}
