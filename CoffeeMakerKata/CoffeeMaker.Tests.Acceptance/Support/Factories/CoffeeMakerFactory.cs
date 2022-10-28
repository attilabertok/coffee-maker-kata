using CoffeeMaker.Api;
using CoffeeMaker.Implementations;
using CoffeeMaker.Tests.Acceptance.Support.Extensions;

namespace CoffeeMaker.Tests.Acceptance.Support.Factories;

public static class CoffeeMakerFactory
{
    public static ICoffeeMaker CreateMark4(
        CoffeeMakerState state,
        ICoffeeMakerCommandInterface commands,
        ISystemStatusProvider systemStatusProvider)
    {
        var stateProvider = ConfigureMockStateProvider();
        stateProvider.SetState(state);
        var mockPollConditionProvider = Substitute.For<IPollConditionProvider>();
        mockPollConditionProvider.PollCondition.Returns(() => CustomPollCondition.RunExactly(1));

        return new Mark4CoffeeMaker(stateProvider, commands, mockPollConditionProvider, systemStatusProvider);
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
