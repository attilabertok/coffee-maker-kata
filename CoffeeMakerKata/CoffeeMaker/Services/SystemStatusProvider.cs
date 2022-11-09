using CoffeeMaker.Core.Entities.Boilers;
using CoffeeMaker.Core.Entities.BrewButtons;
using CoffeeMaker.Core.Entities.WarmerPlates;
using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Services;

public class SystemStatusProvider : ISystemStatusProvider
{
    private readonly IBoiler boiler;
    private readonly IBrewButton brewButton;
    private readonly IWarmerPlate warmerPlate;

    public SystemStatusProvider(IBoiler boiler, IBrewButton brewButton, IWarmerPlate warmerPlate)
    {
        this.boiler = boiler;
        this.brewButton = brewButton;
        this.warmerPlate = warmerPlate;
    }

    public SystemStatus QuerySystemStatus()
    {
        return new SystemStatus(brewButton.Status, warmerPlate.Status, boiler.Status);
    }
}
