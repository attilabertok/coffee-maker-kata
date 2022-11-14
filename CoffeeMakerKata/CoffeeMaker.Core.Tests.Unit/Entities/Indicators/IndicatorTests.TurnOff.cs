using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Indicators;

public partial class IndicatorTests
{
    public class TurnOff : IndicatorTests
    {
        [Fact]
        public void Should_TurnIndicatorOff()
        {
            var indicatorCommands = context.Dependency<IIndicatorCommands>();

            sut.TurnOff();

            indicatorCommands.Received()
                .TurnOff.Execute();
        }
    }
}
