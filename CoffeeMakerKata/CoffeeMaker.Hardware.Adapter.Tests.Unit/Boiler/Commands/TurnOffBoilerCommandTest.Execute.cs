using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Commands;

public partial class TurnOffBoilerCommandTest
{
    public class Execute : TurnOffBoilerCommandTest
    {
        [Fact]
        public void Should_TurnOffBoiler()
        {
            sut.Execute();

            boilerState.Should()
                .Be(BoilerState.Off);
        }
    }
}
