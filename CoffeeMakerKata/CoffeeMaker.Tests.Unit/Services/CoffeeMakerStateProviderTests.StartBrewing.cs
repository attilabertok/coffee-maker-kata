using CoffeeMaker.Core.Enums;
using FluentAssertions;

namespace CoffeeMaker.Tests.Unit.Services;

public partial class CoffeeMakerStateProviderTests
{
    public class StartBrewing : CoffeeMakerStateProviderTests
    {
        [Fact]
        public void Should_SetStateToBrewing()
        {
            sut.StartBrewing();

            sut.State.Should()
                .Be(CoffeeMakerState.Brewing);
        }
    }
}
