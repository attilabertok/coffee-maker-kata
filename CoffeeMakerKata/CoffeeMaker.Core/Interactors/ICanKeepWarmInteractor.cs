using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Interactors;

public interface ICanKeepWarmInteractor
{
    bool CanKeepWarm(WarmerPlateStatus warmerPlateStatus);
}
