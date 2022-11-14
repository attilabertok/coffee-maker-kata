using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Interactors;

public interface ICanBrewInteractor
{
    bool CanBrew(WarmerPlateStatus warmerPlateStatus, BoilerStatus boilerStatus);
}
