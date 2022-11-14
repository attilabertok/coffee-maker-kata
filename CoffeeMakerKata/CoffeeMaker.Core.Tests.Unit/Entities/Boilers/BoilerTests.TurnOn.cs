using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Boilers;

public partial class BoilerTests
{
    public class TurnOn : BoilerTests
    {
        [Fact]
        public void Should_TurnBoilerOn()
        {
            var boilerCommands = context.Dependency<IBoilerCommands>();

            sut.TurnOn();

            boilerCommands.Received()
                .TurnOn.Execute();
        }
    }
}
