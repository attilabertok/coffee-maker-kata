using CoffeeMaker.Hardware.Adapter.Boiler.Mappers;
using EnumsNET;
using FluentAssertions;

using CoreBoilerStatus = CoffeeMaker.Core.Enums.BoilerStatus;
using HardwareBoilerStatus = CoffeeMaker.Hardware.Interface.BoilerStatus;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Mappers;

public class BoilerStatusMapperTests
{
    public class Map : BoilerStatusMapperTests
    {
        public static TheoryData<HardwareBoilerStatus, CoreBoilerStatus> CorrectBoilerStatuses { get; } = new()
        {
            { HardwareBoilerStatus.NotEmpty, CoreBoilerStatus.NotEmpty },
            { HardwareBoilerStatus.Empty, CoreBoilerStatus.Empty }
        };

        [Theory]
        [MemberData(nameof(CorrectBoilerStatuses))]
        public void Should_MapCorrectly(HardwareBoilerStatus source, CoreBoilerStatus expectedResult)
        {
            var result = source.Map();

            result.Should()
                .Be(expectedResult);
        }

        [Fact]
        public void Should_NotAcceptInvalidData()
        {
            var validValues = Enums.GetMembers<HardwareBoilerStatus>()
                .Select(m => Enums.GetUnderlyingValue(m.Value))
                .Cast<int>();
            var invalidValue = validValues.Max() + 1;
            var invalidMember = (HardwareBoilerStatus)invalidValue;
            var action = () => invalidMember.Map();

            action.Should()
                .Throw<ArgumentOutOfRangeException>();
        }
    }
}
