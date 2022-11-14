using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Boilers;

public partial class BoilerTests
{
    public class TurnOff : BoilerTests
    {
        [Fact]
        public void Should_TurnBoilerOff()
        {
            var boilerCommands = context.Dependency<IBoilerCommands>();

            sut.TurnOff();

            boilerCommands.Received()
                .TurnOff.Execute();
        }
    }
}
