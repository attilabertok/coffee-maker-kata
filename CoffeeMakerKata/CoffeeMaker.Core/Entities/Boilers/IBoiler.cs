using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Entities.Boilers;

public interface IBoiler
{
    BoilerStatus Status { get; }

    void TurnOn();

    void TurnOff();
}
