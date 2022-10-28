using CoffeeMaker.Hardware.Adapter.BrewButton.Mappers;
using CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Mappers;
using EnumsNET;
using FluentAssertions;

using CoreBrewButtonStatus = CoffeeMaker.Core.Enums.BrewButtonStatus;
using HardwareBrewButtonStatus = CoffeeMaker.Hardware.Interface.BrewButtonStatus;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.BrewButton.Mappers;

public partial class BrewButtonStatusMapperTests
{
    public class Map : BoilerStatusMapperTests
    {
        public static TheoryData<HardwareBrewButtonStatus, CoreBrewButtonStatus> CorrectBoilerStatuses { get; } = new()
        {
            { HardwareBrewButtonStatus.NotPushed, CoreBrewButtonStatus.NotPushed },
            { HardwareBrewButtonStatus.Pushed, CoreBrewButtonStatus.Pushed }
        };

        [Theory]
        [MemberData(nameof(CorrectBoilerStatuses))]
        public void Should_MapCorrectly(HardwareBrewButtonStatus source, CoreBrewButtonStatus expectedResult)
        {
            var result = source.Map();

            result.Should()
                .Be(expectedResult);
        }

        [Fact]
        public void Should_NotAcceptInvalidData()
        {
            var validValues = Enums.GetMembers<HardwareBrewButtonStatus>()
                .Select(m => Enums.GetUnderlyingValue(m.Value))
                .Cast<int>();
            var invalidValue = validValues.Max() + 1;
            var invalidMember = (HardwareBrewButtonStatus)invalidValue;
            var action = () => invalidMember.Map();

            action.Should()
                .Throw<ArgumentOutOfRangeException>();
        }
    }
}
