using CoffeeMaker.Core.Interactors;

namespace CoffeeMaker.Core.Services.Data.Extensions;

public static class SystemStatusExtensions
{
    public static bool IsBrewingRequested(this SystemStatus systemStatus, IIsBrewingRequestedInteractor interactor)
    {
        return interactor.ShouldBrew(systemStatus);
    }
}
