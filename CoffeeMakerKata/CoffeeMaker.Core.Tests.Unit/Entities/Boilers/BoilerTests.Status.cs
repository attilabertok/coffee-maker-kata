using FluentAssertions;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Boilers;

public partial class BoilerTests
{
    public class Status : BoilerTests
    {
        [Fact]
        public void Should_ReturnBoilerStatusQuery()
        {
            var result = sut.Status;

            result.Should()
                .Be(status.BoilerStatus);
        }
    }
}
