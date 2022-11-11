using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Services.Data;
using CoffeeMaker.Tests.Support.Builders;
using NSubstitute;

namespace CoffeeMaker.Tests.Unit.Implementations;

public partial class Mark4CoffeeMakerTests
{
    private static class Setup
    {
        public static class CoffeeMaker
        {
            public static void ToSkipBrewing(ICoffeeMakerBuilder builder)
            {
                var systemStatusProvider = builder.Context.Dependency<ISystemStatusProvider>();
                var skipBrewing = new SystemStatus(
                    BrewButtonStatus.NotPushed,
                    WarmerPlateStatus.PotEmpty,
                    BoilerStatus.NotEmpty);
                systemStatusProvider.QuerySystemStatus().Returns(skipBrewing);
            }

            public static void ToBrew(ICoffeeMakerBuilder builder)
            {
                var systemStatusProvider = builder.Context.Dependency<ISystemStatusProvider>();
                var toBrew = new SystemStatus(
                    BrewButtonStatus.Pushed,
                    WarmerPlateStatus.PotEmpty,
                    BoilerStatus.NotEmpty);
                systemStatusProvider.QuerySystemStatus().Returns(toBrew);
            }
        }
    }
}
