using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Interactors;
using CoffeeMaker.Core.Services.Data;

using NSubstitute;

namespace CoffeeMaker.Tests.Unit.Implementations;

public partial class Mark4CoffeeMakerTests
{
    public class Start : Mark4CoffeeMakerTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Should_QueryButtonStatus_When_PollConditionIsTrue(int cycles)
        {
            Setup.CoffeeMaker.ToSkipBrewing(builder);
            var sut = builder
                .InState(CoffeeMakerState.Standby)
                .ThatRunsExactly(cycles)
                .Build();
            var mockPollConditionProvider = builder.Context.Dependency<IPollConditionProvider>();

            sut.Start();

            mockPollConditionProvider.Received(cycles + 1)
                .PollCondition();
        }

        [Fact]
        public void Should_Brew_WhenRequested()
        {
            Setup.CoffeeMaker.ToBrew(builder);
            var sut = builder
                .InState(CoffeeMakerState.Standby)
                .Build();
            var attemptToBrewInteractor = builder.Context.Dependency<IAttemptToBrewInteractor>();

            sut.Start();

            attemptToBrewInteractor.Received()
                .AttemptToBrew(Arg.Any<SystemStatus>());
        }
    }
}
