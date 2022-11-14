using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Indicators;

public partial class IndicatorTests
{
    public class TurnOn : IndicatorTests
    {
        [Fact]
        public void Should_TurnIndicatorOn()
        {
            var indicatorCommands = context.Dependency<IIndicatorCommands>();

            sut.TurnOn();

            indicatorCommands.Received()
                .TurnOn.Execute();
        }
    }
}
