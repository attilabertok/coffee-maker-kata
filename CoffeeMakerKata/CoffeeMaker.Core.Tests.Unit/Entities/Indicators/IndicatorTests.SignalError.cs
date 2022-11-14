using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Indicators;

public partial class IndicatorTests
{
    public class SignalError : IndicatorTests
    {
        [Fact]
        public async Task Should_SignalError()
        {
            var indicatorCommands = context.Dependency<IIndicatorCommands>();

            await sut.SignalError();

            await indicatorCommands.Received()
                .SignalError.ExecuteAsync();
        }
    }
}
