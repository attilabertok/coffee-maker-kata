using CoreBrewButtonStatus = CoffeeMaker.Core.Enums.BrewButtonStatus;
using HardwareBrewButtonStatus = CoffeeMaker.Hardware.Interface.BrewButtonStatus;

namespace CoffeeMaker.Hardware.Adapter.BrewButtons.Mappers;

public static class BrewButtonStatusMapper
{
    public static CoreBrewButtonStatus Map(this HardwareBrewButtonStatus instance)
    {
        return instance switch
        {
            HardwareBrewButtonStatus.NotPushed => CoreBrewButtonStatus.NotPushed,
            HardwareBrewButtonStatus.Pushed => CoreBrewButtonStatus.Pushed,
            _ => throw new ArgumentOutOfRangeException(nameof(instance), instance, null)
        };
    }
}
