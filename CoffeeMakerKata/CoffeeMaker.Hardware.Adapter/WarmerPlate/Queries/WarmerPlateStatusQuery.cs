using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Mappers;
using CoffeeMaker.Hardware.Interface;

using WarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlate.Queries;

public class WarmerPlateStatusQuery :
    IQuery<WarmerPlateStatus>
{
    private readonly ICoffeeMakerApi api;

    public WarmerPlateStatusQuery(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public WarmerPlateStatus Execute()
    {
        return api.GetWarmerPlateStatus().Map();
    }
}
