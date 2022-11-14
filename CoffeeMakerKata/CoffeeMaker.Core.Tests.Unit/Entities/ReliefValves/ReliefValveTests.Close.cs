using CoffeeMaker.Core.Api.Commands;
using NSubstitute;

namespace CoffeeMaker.Core.Tests.Unit.Entities.ReliefValves;

public partial class ReliefValveTests
{
    public class Close : ReliefValveTests
    {
        [Fact]
        public void Should_CloseReliefValve()
        {
            var reliefValveCommands = context.Dependency<IReliefValveCommands>();

            sut.Close();

            reliefValveCommands.Received()
                .Close.Execute();
        }
    }
}
