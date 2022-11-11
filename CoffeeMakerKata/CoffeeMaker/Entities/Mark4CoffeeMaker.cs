using CoffeeMaker.Core;
using CoffeeMaker.Core.Entities.Boilers;
using CoffeeMaker.Core.Entities.BrewButtons;
using CoffeeMaker.Core.Entities.Indicators;
using CoffeeMaker.Core.Entities.ReliefValves;
using CoffeeMaker.Core.Entities.WarmerPlates;
using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Interactors;
using CoffeeMaker.Core.Services.Data;
using CoffeeMaker.Core.Services.Data.Extensions;

namespace CoffeeMaker.Entities;

public class Mark4CoffeeMaker :
    ICoffeeMaker
{
    private readonly IBoiler boiler;
    private readonly IBrewButton brewButton;
    private readonly IIndicator indicator;
    private readonly IReliefValve reliefValve;
    private readonly IWarmerPlate warmerPlate;
    private readonly ICoffeeMakerStateProvider stateProvider;
    private readonly IPollConditionProvider pollConditionProvider;
    private readonly ISystemStatusProvider systemStatusProvider;
    private SystemStatus systemStatus;

    public Mark4CoffeeMaker(
        IBoiler boiler,
        IBrewButton brewButton,
        IIndicator indicator,
        IReliefValve reliefValve,
        IWarmerPlate warmerPlate,
        ICoffeeMakerStateProvider stateProvider,
        IPollConditionProvider pollConditionProvider,
        ISystemStatusProvider systemStatusProvider)
    {
        this.stateProvider = stateProvider;
        this.boiler = boiler;
        this.brewButton = brewButton;
        this.indicator = indicator;
        this.reliefValve = reliefValve;
        this.warmerPlate = warmerPlate;
        this.pollConditionProvider = pollConditionProvider;
        this.systemStatusProvider = systemStatusProvider;

        systemStatus = systemStatusProvider.QuerySystemStatus();
    }

    public CoffeeMakerState State => stateProvider.State;

    public void Start()
    {
        while (pollConditionProvider.PollCondition())
        {
            systemStatus = systemStatusProvider.QuerySystemStatus();

            Run();
        }
    }

    private void Run()
    {
        if (systemStatus.IsBrewingRequested())
        {
            Brew();
        }
        else
        {
            KeepWarm();
        }
    }

    private void KeepWarm()
    {
    }

    private void Brew()
    {
        AttemptToBrewInteractor.AttemptToBrew(stateProvider, systemStatus);
    }
}
