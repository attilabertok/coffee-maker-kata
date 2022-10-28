namespace CoffeeMaker;

public interface ICoffeeMakerStateProvider
{
    public CoffeeMakerState State { get; }

    void SwitchToError();

    void SwitchToStandby();

    void StartBrewing();
}
