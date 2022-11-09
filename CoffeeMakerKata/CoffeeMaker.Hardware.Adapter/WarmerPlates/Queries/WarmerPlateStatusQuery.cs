using CoffeeMaker.Core.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlates.Mappers;
using CoffeeMaker.Hardware.Interface;

using WarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlates.Queries;

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
