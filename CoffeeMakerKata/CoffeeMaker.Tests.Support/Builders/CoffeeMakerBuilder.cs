using CoffeeMaker.Core;
using CoffeeMaker.Core.Enums;
using CoffeeMaker.Entities;
using CoffeeMaker.Tests.Support.Extensions;
using CoffeeMaker.Tests.Support.Factories;
using FluentArrange;
using NSubstitute;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Tests.Support.Builders;

public class CoffeeMakerBuilder : ICoffeeMakerBuilder
{
    private CoffeeMakerState? state;
    private bool isCycleCountConfigured;

    public CoffeeMakerBuilder()
    {
        Context = Arrange.For<Mark4CoffeeMaker>();
    }

    public FluentArrangeContext<Mark4CoffeeMaker> Context { get; set; }

    public ICoffeeMaker Build()
    {
        var stateProvider = ConfigureMockStateProvider();
        stateProvider.SetState(state ?? CoffeeMakerState.Standby);

        if (!isCycleCountConfigured)
        {
            Context.WithDependency(CreateMockPollConditionProvider());
        }

        var result = Context
            .WithDependency(stateProvider)
            .BuildSut();

        isCycleCountConfigured = false;

        return result;
    }

    public ICoffeeMakerBuilder InState(CoffeeMakerState desiredState)
    {
        state = desiredState;

        return this;
    }

    public ICoffeeMakerBuilder WithSystemStatusProvider(ISystemStatusProvider desiredSystemStatusProvider)
    {
        Context = Context.WithDependency(desiredSystemStatusProvider);

        return this;
    }

    public ICoffeeMakerBuilder ThatRunsExactly(int cycles)
    {
        isCycleCountConfigured = true;
        Context = Context.WithDependency(CreateMockPollConditionProvider(cycles));

        return this;
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

    private IPollConditionProvider CreateMockPollConditionProvider(int cycles = 1)
    {
        var mockPollConditionProvider = Context.Dependency<IPollConditionProvider>();
        var pollCondition = new CustomPollCondition();
        mockPollConditionProvider.PollCondition.Returns(() => pollCondition.RunExactly(cycles));

        return mockPollConditionProvider;
    }
}
