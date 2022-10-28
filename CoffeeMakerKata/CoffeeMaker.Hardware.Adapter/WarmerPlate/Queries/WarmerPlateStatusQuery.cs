using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Interface;

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
        return api.GetWarmerPlateStatus();
    }
}
