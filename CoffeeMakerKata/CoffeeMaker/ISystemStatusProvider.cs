using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker;

public interface ISystemStatusProvider
{
    SystemStatus QuerySystemStatus();
}
