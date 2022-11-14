using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Interactors;

public class CanKeepWarmInteractor : ICanKeepWarmInteractor
{
    public bool CanKeepWarm(WarmerPlateStatus warmerPlateStatus)
    {
        return warmerPlateStatus == WarmerPlateStatus.PotNotEmpty;
    }
}
