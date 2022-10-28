using CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Mappers;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Mappers;
using EnumsNET;
using FluentAssertions;

using CoreWarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;
using HardwareWarmerPlateStatus = CoffeeMaker.Hardware.Interface.WarmerPlateStatus;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Mappers;

public partial class WarmerPlateStatusMapperTests
{
    public class Map : BoilerStatusMapperTests
    {
        public static TheoryData<HardwareWarmerPlateStatus, CoreWarmerPlateStatus> CorrectBoilerStatuses { get; } = new()
        {
            { HardwareWarmerPlateStatus.PotNotEmpty, CoreWarmerPlateStatus.PotNotEmpty },
            { HardwareWarmerPlateStatus.PotEmpty, CoreWarmerPlateStatus.PotEmpty },
            { HardwareWarmerPlateStatus.WarmerEmpty, CoreWarmerPlateStatus.WarmerEmpty }
        };

        [Theory]
        [MemberData(nameof(CorrectBoilerStatuses))]
        public void Should_MapCorrectly(HardwareWarmerPlateStatus source, CoreWarmerPlateStatus expectedResult)
        {
            var result = source.Map();

            result.Should()
                .Be(expectedResult);
        }

        [Fact]
        public void Should_NotAcceptInvalidData()
        {
            var validValues = Enums.GetMembers<HardwareWarmerPlateStatus>()
                .Select(m => Enums.GetUnderlyingValue(m.Value))
                .Cast<int>();
            var invalidValue = validValues.Max() + 1;
            var invalidMember = (HardwareWarmerPlateStatus)invalidValue;
            var action = () => invalidMember.Map();

            action.Should()
                .Throw<ArgumentOutOfRangeException>();
        }
    }
}
