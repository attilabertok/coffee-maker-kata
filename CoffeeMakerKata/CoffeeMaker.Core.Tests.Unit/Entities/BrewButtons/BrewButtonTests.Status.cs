using FluentAssertions;

namespace CoffeeMaker.Core.Tests.Unit.Entities.BrewButtons;

public partial class BrewButtonTests
{
    public class Status : BrewButtonTests
    {
        [Fact]
        public void Should_ReturnBrewButtonStatusQuery()
        {
            var result = sut.Status;

            result.Should()
                .Be(status.BrewButtonStatus);
        }
    }
}
