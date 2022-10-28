using CoffeeMaker.Core.Enums;
using FluentAssertions;

namespace CoffeeMaker.Tests.Unit.Services;

public partial class CoffeeMakerStateProviderTests
{
    public class SwitchToError : CoffeeMakerStateProviderTests
    {
        [Fact]
        public void Should_SetStateToError()
        {
            sut.SwitchToError();

            sut.State.Should()
                .Be(CoffeeMakerState.Error);
        }
    }
}
