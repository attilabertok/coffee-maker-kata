using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.ReliefValve.Commands;

public partial class OpenReliefValveCommandTests
{
    public class Execute : OpenReliefValveCommandTests
    {
        [Fact]
        public void Should_OpenReliefValve()
        {
            sut.Execute();

            reliefValveState.Should()
                .Be(ReliefValveState.Open);
        }
    }
}
