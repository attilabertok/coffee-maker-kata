using FluentAssertions;

namespace CoffeeMaker.Core.Tests.Unit.Entities.WarmerPlates;

public partial class WarmerPlateTests
{
    public class Status : WarmerPlateTests
    {
        [Fact]
        public void Should_ReturnWarmerPlateStatusQuery()
        {
            var result = sut.Status;

            result.Should()
                .Be(status.WarmerPlateStatus);
        }
    }
}
