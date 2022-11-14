using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Core.Interactors;

public class IsBrewingRequestedInteractor : IIsBrewingRequestedInteractor
{
    public bool ShouldBrew(SystemStatus systemStatus)
    {
        return systemStatus.BrewButtonStatus == BrewButtonStatus.Pushed;
    }
}
