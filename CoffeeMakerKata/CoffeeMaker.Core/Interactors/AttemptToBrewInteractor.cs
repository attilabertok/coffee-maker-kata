using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Core.Interactors;

public class AttemptToBrewInteractor
{
    public static void AttemptToBrew(ICoffeeMakerStateProvider stateProvider, SystemStatus systemStatus)
    {
        if (CanBrewInteractor.Execute(systemStatus.WarmerPlateStatus, systemStatus.BoilerStatus))
        {
            stateProvider.StartBrewing();
        }
        else
        {
            stateProvider.SwitchToError();
        }
    }
}
