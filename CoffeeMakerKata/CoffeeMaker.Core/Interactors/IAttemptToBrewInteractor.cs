using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Core.Interactors;

public interface IAttemptToBrewInteractor
{
    void AttemptToBrew(SystemStatus systemStatus);
}
