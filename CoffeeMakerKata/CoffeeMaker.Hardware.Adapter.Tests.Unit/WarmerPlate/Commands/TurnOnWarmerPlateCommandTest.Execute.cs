using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Commands;

public partial class TurnOnWarmerPlateCommandTest
{
    public class Execute : TurnOnWarmerPlateCommandTest
    {
        [Fact]
        public void Should_TurnOnWarmerPlate()
        {
            sut.Execute();

            warmerPlateState.Should()
                .Be(WarmerPlateState.On);
        }
    }
}
