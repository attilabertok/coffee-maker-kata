using CoffeeMaker.Api;
using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Services;

public class SystemStatusProvider : ISystemStatusProvider
{
    private readonly ICoffeeMakerQueryInterface queries;

    public SystemStatusProvider(ICoffeeMakerQueryInterface queries)
    {
        this.queries = queries;
    }

    public SystemStatus QuerySystemStatus()
    {
        var brewButtonStatus = queries.BrewButton.Status.Execute();
        var warmerPlateStatus = queries.WarmerPlate.Status.Execute();
        var boilerStatus = queries.Boiler.Status.Execute();

        return new SystemStatus(brewButtonStatus, warmerPlateStatus, boilerStatus);
    }
}
