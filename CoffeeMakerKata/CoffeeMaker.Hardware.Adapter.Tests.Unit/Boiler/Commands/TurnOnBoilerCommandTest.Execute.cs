using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Commands;

public partial class TurnOnBoilerCommandTest
{
    public class Execute : TurnOnBoilerCommandTest
    {
        [Fact]
        public void Should_TurnOffBoiler()
        {
            sut.Execute();

            boilerState.Should()
                .Be(BoilerState.On);
        }
    }
}
