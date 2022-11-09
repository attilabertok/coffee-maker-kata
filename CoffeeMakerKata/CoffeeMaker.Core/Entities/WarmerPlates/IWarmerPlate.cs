using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Entities.WarmerPlates;

public interface IWarmerPlate
{
    WarmerPlateStatus Status { get; }

    void TurnOn();

    void TurnOff();
}
