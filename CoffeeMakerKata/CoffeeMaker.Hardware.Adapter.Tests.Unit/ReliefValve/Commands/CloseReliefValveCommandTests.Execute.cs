using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.ReliefValve.Commands;

public partial class CloseReliefValveCommandTests
{
    public class Execute : CloseReliefValveCommandTests
    {
        [Fact]
        public void Should_CloseReliefValve()
        {
            sut.Execute();

            reliefValveState.Should()
                .Be(ReliefValveState.Closed);
        }
    }
}
