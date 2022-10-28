using CoffeeMaker.Core.Enums;
using CoffeeMaker.Implementations;

namespace CoffeeMaker.Interactors;

public class IsBrewingRequestedInteractor
{
    public static bool Execute(SystemStatus systemStatus)
    {
        return systemStatus.BrewButtonStatus == BrewButtonStatus.Pushed;
    }
}
