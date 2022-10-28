using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core;

public interface ICoffeeMakerStateProvider
{
    public CoffeeMakerState State { get; }

    void SwitchToError();

    void SwitchToStandby();

    void StartBrewing();
}
