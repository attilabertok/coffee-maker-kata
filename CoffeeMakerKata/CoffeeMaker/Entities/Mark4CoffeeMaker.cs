using CoffeeMaker.Api;
using CoffeeMaker.Core;
using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Interactors;
using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Entities;

public class Mark4CoffeeMaker :
    ICoffeeMaker
{
    private readonly ICoffeeMakerStateProvider stateProvider;
    private readonly ICoffeeMakerCommandInterface commands;
    private readonly IPollConditionProvider pollConditionProvider;
    private readonly ISystemStatusProvider systemStatusProvider;

    public Mark4CoffeeMaker(
        ICoffeeMakerStateProvider stateProvider,
        ICoffeeMakerCommandInterface commands,
        IPollConditionProvider pollConditionProvider,
        ISystemStatusProvider systemStatusProvider)
    {
        this.stateProvider = stateProvider;
        this.commands = commands;
        this.pollConditionProvider = pollConditionProvider;
        this.systemStatusProvider = systemStatusProvider;
    }

    public CoffeeMakerState State => stateProvider.State;

    public void Start()
    {
        while (pollConditionProvider.PollCondition())
        {
            var systemStatus = systemStatusProvider.QuerySystemStatus();

            Run(systemStatus);
        }
    }

    private void Run(SystemStatus systemStatus)
    {
        if (IsBrewingRequestedInteractor.Execute(systemStatus))
        {
            AttemptToBrewInteractor.AttemptToBrew(stateProvider, systemStatus);
        }
    }
}
