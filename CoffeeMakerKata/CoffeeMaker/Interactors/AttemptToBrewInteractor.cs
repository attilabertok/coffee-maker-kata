using CoffeeMaker.Implementations;

namespace CoffeeMaker.Interactors;

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
