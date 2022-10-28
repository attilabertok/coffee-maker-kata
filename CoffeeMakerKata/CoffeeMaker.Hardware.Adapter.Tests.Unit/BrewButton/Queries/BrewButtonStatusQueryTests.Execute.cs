using CoffeeMaker.Hardware.Adapter.Tests.Unit.TestData;
using CoffeeMaker.Hardware.Interface;
using FluentAssertions;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.BrewButton.Queries;

public partial class BrewButtonStatusQueryTests
{
    public class Execute : BrewButtonStatusQueryTests
    {
        public static EnumTheoryData<BrewButtonStatus> BrewButtonStatusValues { get; } = new();

        [Theory]
        [MemberData(nameof(BrewButtonStatusValues))]
        public void Should_ReturnBrewButtonStatusFromApi(BrewButtonStatus brewButtonStatus)
        {
            mockApi.GetBrewButtonStatus()
                .Returns(brewButtonStatus);

            var result = sut.Execute();

            result.Should()
                .Be(brewButtonStatus);
        }
    }
}
