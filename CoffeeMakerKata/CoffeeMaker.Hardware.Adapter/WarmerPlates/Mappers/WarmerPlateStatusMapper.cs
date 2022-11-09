using CoreWarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;
using HardwareWarmerPlateStatus = CoffeeMaker.Hardware.Interface.WarmerPlateStatus;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlates.Mappers;

public static class WarmerPlateStatusMapper
{
    public static CoreWarmerPlateStatus Map(this HardwareWarmerPlateStatus instance)
    {
        return instance switch
        {
            HardwareWarmerPlateStatus.PotEmpty => CoreWarmerPlateStatus.PotEmpty,
            HardwareWarmerPlateStatus.PotNotEmpty => CoreWarmerPlateStatus.PotNotEmpty,
            HardwareWarmerPlateStatus.WarmerEmpty => CoreWarmerPlateStatus.WarmerEmpty,
            _ => throw new ArgumentOutOfRangeException(nameof(instance), instance, null)
        };
    }
}
