using CoffeeMaker.Core.Enums;
using FluentAssertions;

namespace CoffeeMaker.Core.Tests.Unit.Interactors;

public partial class CanKeepWarmInteractorTests
{
    public class CanKeepWarm : CanKeepWarmInteractorTests
    {
        public static TheoryData<string, WarmerPlateStatus> WarmerPlateStatusOptionsNotReadyForKeepingWarm { get; } = new()
            {
                { "warmer plate has an empty pot", WarmerPlateStatus.PotEmpty },
                { "warmer plate has no pot", WarmerPlateStatus.WarmerEmpty }
            };

        [Fact]
        public void Should_ReturnTrue_When_HasANonEmptyPot()
        {
            var result = sut.CanKeepWarm(WarmerPlateStatus.PotNotEmpty);

            result.Should()
                .BeTrue();
        }

        [Theory]
        [MemberData(nameof(WarmerPlateStatusOptionsNotReadyForKeepingWarm))]
        public void Should_ReturnFalse_When_DoesNotHaveANonEmptyPot(string reason, WarmerPlateStatus warmerPlateStatus)
        {
            var result = sut.CanKeepWarm(warmerPlateStatus);

            result.Should()
                .BeFalse(reason);
        }
    }
}
