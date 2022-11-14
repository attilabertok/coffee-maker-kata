using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.WarmerPlates;

public partial class WarmerPlateTests
{
    public class TurnOn : WarmerPlateTests
    {
        [Fact]
        public void Should_TurnWarmerPlateOn()
        {
            var warmerPlateCommands = context.Dependency<IWarmerPlateCommands>();

            sut.TurnOn();

            warmerPlateCommands.Received()
                .TurnOn.Execute();
        }
    }
}
