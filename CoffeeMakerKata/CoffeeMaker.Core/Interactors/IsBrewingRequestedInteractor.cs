using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Core.Interactors;

public class IsBrewingRequestedInteractor
{
    public static bool Execute(SystemStatus systemStatus)
    {
        return systemStatus.BrewButtonStatus == BrewButtonStatus.Pushed;
    }
}
