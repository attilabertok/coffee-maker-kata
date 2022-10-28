using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Indicator.Commands;

public partial class SignalErrorCommandTests
{
    public class ExecuteAsync : SignalErrorCommandTests
    {
        [Fact]
        public async Task Should_FinishWithIndicatorTurnedOff()
        {
            await sut.ExecuteAsync();

            indicatorState.Should()
                .Be(IndicatorState.Off);
        }

        [Fact]
        public async Task Should_FlashIndicator()
        {
            await sut.ExecuteAsync();

            indicatorFlashCount.Should()
                .BeGreaterThan(1);
        }
    }
}
