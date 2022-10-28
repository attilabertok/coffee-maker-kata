using FluentAssertions;

namespace CoffeeMaker.Tests.Unit.Services;

public partial class CancellationPollConditionProviderTests
{
    public class PollCondition : CancellationPollConditionProviderTests
    {
        [Fact]
        public void Should_ReturnFalse_When_CancellationIsNotRequested()
        {
            var result = sut.PollCondition();

            result.Should()
                .BeTrue();
        }

        [Fact]
        public void Should_ReturnTrue_When_CancellationIsRequested()
        {
            cancellationTokenSource.Cancel();

            var result = sut.PollCondition();

            result.Should()
                .BeFalse();
        }
    }
}
