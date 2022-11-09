using CoffeeMaker.Core;
using CoffeeMaker.Core.Entities.Boilers;
using CoffeeMaker.Core.Entities.BrewButtons;
using CoffeeMaker.Core.Entities.Indicators;
using CoffeeMaker.Core.Entities.ReliefValves;
using CoffeeMaker.Core.Entities.WarmerPlates;
using CoffeeMaker.Core.Enums;
using CoffeeMaker.Entities;
using CoffeeMaker.Tests.Acceptance.Support.Extensions;

namespace CoffeeMaker.Tests.Acceptance.Support.Factories;

public static class CoffeeMakerFactory
{
    public static ICoffeeMaker CreateMark4(
        CoffeeMakerState state,
        ISystemStatusProvider systemStatusProvider)
    {
        var stateProvider = ConfigureMockStateProvider();
        stateProvider.SetState(state);
        var mockPollConditionProvider = Substitute.For<IPollConditionProvider>();
        var pollCondition = new CustomPollCondition();
        mockPollConditionProvider.PollCondition.Returns(() => pollCondition.RunExactly(1));

        var boiler = Substitute.For<IBoiler>();
        var brewButton = Substitute.For<IBrewButton>();
        var indicator = Substitute.For<IIndicator>();
        var reliefValve = Substitute.For<IReliefValve>();
        var warmerPlate = Substitute.For<IWarmerPlate>();

        return new Mark4CoffeeMaker(stateProvider, boiler, brewButton, indicator, reliefValve, warmerPlate, mockPollConditionProvider, systemStatusProvider);
    }

    private static ICoffeeMakerStateProvider ConfigureMockStateProvider()
    {
        var stateProvider = Substitute.For<ICoffeeMakerStateProvider>();
        stateProvider.When(p => p.StartBrewing())
            .Do(_ => stateProvider.SetState(CoffeeMakerState.Brewing));
        stateProvider.When(p => p.SwitchToError())
            .Do(_ => stateProvider.SetState(CoffeeMakerState.Error));
        stateProvider.When(p => p.SwitchToStandby())
            .Do(_ => stateProvider.SetState(CoffeeMakerState.Standby));

        return stateProvider;
    }
}
