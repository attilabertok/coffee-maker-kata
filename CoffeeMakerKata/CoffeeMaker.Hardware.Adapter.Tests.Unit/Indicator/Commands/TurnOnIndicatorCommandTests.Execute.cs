using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Indicator.Commands;

public partial class TurnOnIndicatorCommandTests
{
    public class Execute : TurnOnIndicatorCommandTests
    {
        [Fact]
        public void Should_TurnOnIndicator()
        {
            sut.Execute();

            indicatorState.Should()
                .Be(IndicatorState.On);
        }
    }
}
