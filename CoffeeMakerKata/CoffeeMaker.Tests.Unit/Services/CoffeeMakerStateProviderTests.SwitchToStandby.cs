using CoffeeMaker.Core.Enums;
using FluentAssertions;

namespace CoffeeMaker.Tests.Unit.Services;

public partial class CoffeeMakerStateProviderTests
{
    public class SwitchToStandby : CoffeeMakerStateProviderTests
    {
        [Fact]
        public void Should_SetStateToStandby()
        {
            sut.SwitchToStandby();

            sut.State.Should()
                .Be(CoffeeMakerState.Standby);
        }
    }
}
