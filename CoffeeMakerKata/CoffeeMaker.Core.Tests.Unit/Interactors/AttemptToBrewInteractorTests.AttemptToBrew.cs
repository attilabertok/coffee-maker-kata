using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Services.Data;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Interactors;

public partial class AttemptToBrewInteractorTests
{
    public class AttemptToBrew : AttemptToBrewInteractorTests
    {
        [Fact]
        public void Should_StartBrewing_When_CanBrew()
        {
            canBrewInteractor.CanBrew(Arg.Any<WarmerPlateStatus>(), Arg.Any<BoilerStatus>())
                .Returns(true);
            var systemStatus = new SystemStatus(BrewButtonStatus.Pushed, WarmerPlateStatus.PotEmpty, BoilerStatus.NotEmpty);

            sut.AttemptToBrew(systemStatus);

            context.Dependency<ICoffeeMakerStateProvider>()
                .Received().StartBrewing();
        }

        [Fact]
        public void Should_IndicateError_When_CannotBrew()
        {
            canBrewInteractor.CanBrew(Arg.Any<WarmerPlateStatus>(), Arg.Any<BoilerStatus>())
                .Returns(false);
            var systemStatus = new SystemStatus(BrewButtonStatus.Pushed, WarmerPlateStatus.PotEmpty, BoilerStatus.NotEmpty);

            sut.AttemptToBrew(systemStatus);

            context.Dependency<ICoffeeMakerStateProvider>()
                .Received().SwitchToError();
        }
    }
}
