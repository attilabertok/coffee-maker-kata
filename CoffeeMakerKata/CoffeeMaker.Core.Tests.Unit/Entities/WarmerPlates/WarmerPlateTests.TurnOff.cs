using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.WarmerPlates;

public partial class WarmerPlateTests
{
    public class TurnOff : WarmerPlateTests
    {
        [Fact]
        public void Should_TurnWarmerPlateOff()
        {
            var warmerPlateCommands = context.Dependency<IWarmerPlateCommands>();

            sut.TurnOff();

            warmerPlateCommands.Received()
                .TurnOff.Execute();
        }
    }
}
