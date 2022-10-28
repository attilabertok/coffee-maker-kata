using CoffeeMaker.Api;
using CoffeeMaker.Api.Queries;
using CoffeeMaker.Hardware.Adapter.Boiler;
using CoffeeMaker.Hardware.Adapter.BrewButton;
using CoffeeMaker.Hardware.Adapter.WarmerPlate;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter;

public class CoffeeMakerQueryInterface : ICoffeeMakerQueryInterface
{
    public CoffeeMakerQueryInterface(ICoffeeMakerApi api)
    {
        Boiler = new BoilerQueries(api);
        BrewButton = new BrewButtonQueries(api);
        WarmerPlate = new WarmerPlateQueries(api);
    }

    public IBoilerQueries Boiler { get; }

    public IBrewButtonQueries BrewButton { get; }

    public IWarmerPlateQueries WarmerPlate { get; }
}
