using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Core.Interactors;

public class AttemptToBrewInteractor : IAttemptToBrewInteractor
{
    private readonly ICoffeeMakerStateProvider stateProvider;
    private readonly ICanBrewInteractor canBrewInteractor;

    public AttemptToBrewInteractor(
        ICoffeeMakerStateProvider stateProvider,
        ICanBrewInteractor canBrewInteractor)
    {
        this.stateProvider = stateProvider;
        this.canBrewInteractor = canBrewInteractor;
    }

    public void AttemptToBrew(SystemStatus systemStatus)
    {
        if (CanBrew(systemStatus))
        {
            stateProvider.StartBrewing();
        }
        else
        {
            stateProvider.SwitchToError();
        }
    }

    private bool CanBrew(SystemStatus systemStatus)
    {
        return canBrewInteractor.CanBrew(systemStatus.WarmerPlateStatus, systemStatus.BoilerStatus);
    }
}
