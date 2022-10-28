using CoffeeMaker.Implementations;

namespace CoffeeMaker;

public interface ISystemStatusProvider
{
    SystemStatus QuerySystemStatus();
}
