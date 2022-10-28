using CoreBoilerStatus = CoffeeMaker.Core.Enums.BoilerStatus;
using HardwareBoilerStatus = CoffeeMaker.Hardware.Interface.BoilerStatus;

namespace CoffeeMaker.Hardware.Adapter.Boiler.Mappers;

public static class BoilerStatusMapper
{
    public static CoreBoilerStatus Map(this HardwareBoilerStatus instance)
    {
        return instance switch
        {
            HardwareBoilerStatus.Empty => CoreBoilerStatus.Empty,
            HardwareBoilerStatus.NotEmpty => CoreBoilerStatus.NotEmpty,
            _ => throw new ArgumentOutOfRangeException(nameof(instance), instance, null)
        };
    }
}
