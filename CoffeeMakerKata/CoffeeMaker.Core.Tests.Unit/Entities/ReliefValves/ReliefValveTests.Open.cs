using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.ReliefValves;

public partial class ReliefValveTests
{
    public class Open : ReliefValveTests
    {
        [Fact]
        public void Should_OpenReliefValve()
        {
            var reliefValveCommands = context.Dependency<IReliefValveCommands>();

            sut.Open();

            reliefValveCommands.Received()
                .Open.Execute();
        }
    }
}
