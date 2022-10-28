using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Services.Data;

public class SystemStatus
{
    public SystemStatus(BrewButtonStatus brewButtonStatus, WarmerPlateStatus warmerPlateStatus, BoilerStatus boilerStatus)
    {
        BrewButtonStatus = brewButtonStatus;
        WarmerPlateStatus = warmerPlateStatus;
        BoilerStatus = boilerStatus;
    }

    public BrewButtonStatus BrewButtonStatus { get; }

    public WarmerPlateStatus WarmerPlateStatus { get; }

    public BoilerStatus BoilerStatus { get; }
}
