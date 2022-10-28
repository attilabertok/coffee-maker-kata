using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Interactors;

public class CanBrewInteractor
{
    public static bool Execute(WarmerPlateStatus warmerPlateStatus, BoilerStatus boilerStatus)
    {
        return warmerPlateStatus == WarmerPlateStatus.PotEmpty && boilerStatus == BoilerStatus.NotEmpty;
    }
}
