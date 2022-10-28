using CoffeeMaker.Api.Queries;

namespace CoffeeMaker.Api;

public interface ICoffeeMakerQueryInterface
{
    IBoilerQueries Boiler { get; }

    IBrewButtonQueries BrewButton { get; }

    IWarmerPlateQueries WarmerPlate { get; }
}
