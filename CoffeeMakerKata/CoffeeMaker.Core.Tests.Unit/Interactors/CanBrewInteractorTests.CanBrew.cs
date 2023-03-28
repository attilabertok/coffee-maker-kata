using CoffeeMaker.Core.Enums;
using FluentAssertions;

namespace CoffeeMaker.Core.Tests.Unit.Interactors;

public partial class CanBrewInteractorTests
{
    public class CanBrew : CanBrewInteractorTests
    {
        public static TheoryData<string, WarmerPlateStatus> WarmerPlateStatusOptionsNotReadyForBrewing { get; } = new()
        {
            { "warmer plate has a non-empty pot", WarmerPlateStatus.PotNotEmpty },
            { "warmer plate has no pot", WarmerPlateStatus.WarmerEmpty }
        };

        public static TheoryData<string, WarmerPlateStatus> AllWarmerPlateStatusOptions { get; } = new()
        {
            { "warmer plate has an empty pot", WarmerPlateStatus.PotEmpty },
            { "warmer plate has a non-empty pot", WarmerPlateStatus.PotNotEmpty },
            { "warmer plate has no pot", WarmerPlateStatus.WarmerEmpty }
        };

        [Fact]
        public void ReturnsTrue_When_WarmerPlateHasAnEmptyPotAndBoilerIsNotEmpty()
        {
            var result = sut.CanBrew(WarmerPlateStatus.PotEmpty, BoilerStatus.NotEmpty);

            result.Should()
                .BeTrue();
        }

        [Theory]
        [MemberData(nameof(AllWarmerPlateStatusOptions))]
        public void Should_ReturnFalse_When_BoilerIsEmpty(string reason, WarmerPlateStatus warmerPlateStatus)
        {
            var result = sut.CanBrew(warmerPlateStatus, BoilerStatus.Empty);

            result.Should()
                .BeFalse(reason);
        }

        [Theory]
        [MemberData(nameof(WarmerPlateStatusOptionsNotReadyForBrewing))]
        public void Should_ReturnFalse_When_WarmerPlateDoesNotHaveAnEmptyPot(
            string reason,
            WarmerPlateStatus warmerPlateStatus)
        {
            var result = sut.CanBrew(warmerPlateStatus, BoilerStatus.NotEmpty);

            result.Should()
                .BeFalse(reason);
        }
    }
}
