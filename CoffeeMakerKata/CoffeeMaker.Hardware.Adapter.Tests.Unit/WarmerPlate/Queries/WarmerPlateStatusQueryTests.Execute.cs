using CoffeeMaker.Hardware.Adapter.Tests.Unit.TestData;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Mappers;
using CoffeeMaker.Hardware.Interface;
using FluentAssertions;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Queries;

public partial class WarmerPlateStatusQueryTests
{
    public class Execute : WarmerPlateStatusQueryTests
    {
        public static EnumTheoryData<WarmerPlateStatus> WarmerPlateStatusValues { get; } = new();

        [Theory]
        [MemberData(nameof(WarmerPlateStatusValues))]
        public void Should_ReturnWarmerPlateStatusFromApi(WarmerPlateStatus warmerPlateStatus)
        {
            mockApi.GetWarmerPlateStatus()
                .Returns(warmerPlateStatus);
            var expected = warmerPlateStatus.Map();

            var result = sut.Execute();

            result.Should()
                .Be(expected);
        }
    }
}
