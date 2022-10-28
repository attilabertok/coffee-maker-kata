using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Indicator.Commands;

public partial class TurnOffIndicatorCommandTests
{
    public class Execute : TurnOffIndicatorCommandTests
    {
        [Fact]
        public void Should_TurnOffIndicator()
        {
            sut.Execute();

            indicatorState.Should()
                .Be(IndicatorState.Off);
        }
    }
}
