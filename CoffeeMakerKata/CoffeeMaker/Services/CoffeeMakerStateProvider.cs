namespace CoffeeMaker.Services;

public class CoffeeMakerStateProvider :
    ICoffeeMakerStateProvider
{
    public CoffeeMakerState State { get; private set; }

    public void SwitchToError()
    {
        State = CoffeeMakerState.Error;
    }

    public void SwitchToStandby()
    {
        State = CoffeeMakerState.Standby;
    }

    public void StartBrewing()
    {
        State = CoffeeMakerState.Brewing;
    }
}
