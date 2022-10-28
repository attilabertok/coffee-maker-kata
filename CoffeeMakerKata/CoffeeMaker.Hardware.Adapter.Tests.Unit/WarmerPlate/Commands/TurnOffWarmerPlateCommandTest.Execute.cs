using CoffeeMaker.Hardware.Interface;
using FluentAssertions;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.WarmerPlate.Commands;

public partial class TurnOffWarmerPlateCommandTest
{
    public class Execute : TurnOffWarmerPlateCommandTest
    {
        [Fact]
        public void Should_TurnOffWarmerPlate()
        {
            sut.Execute();

            warmerPlateState.Should()
                .Be(WarmerPlateState.Off);
        }
    }
}
