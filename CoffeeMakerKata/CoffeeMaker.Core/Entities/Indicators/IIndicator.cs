namespace CoffeeMaker.Core.Entities.Indicators;

public interface IIndicator
{
    Task SignalError();

    void TurnOn();

    void TurnOff();
}
