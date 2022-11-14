using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Interactors;

public class CanBrewInteractor : ICanBrewInteractor
{
    public bool CanBrew(WarmerPlateStatus warmerPlateStatus, BoilerStatus boilerStatus)
    {
        return warmerPlateStatus == WarmerPlateStatus.PotEmpty && boilerStatus == BoilerStatus.NotEmpty;
    }
}
