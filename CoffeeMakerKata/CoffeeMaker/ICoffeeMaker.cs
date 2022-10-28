using CoffeeMaker.Core.Enums;

namespace CoffeeMaker;

public interface ICoffeeMaker
{
    CoffeeMakerState State { get; }

    void Start();
}
