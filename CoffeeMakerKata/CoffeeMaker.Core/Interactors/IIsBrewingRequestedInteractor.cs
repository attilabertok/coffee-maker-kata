using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Core.Interactors
{
    public interface IIsBrewingRequestedInteractor
    {
        bool ShouldBrew(SystemStatus systemStatus);
    }
}
