using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.Boiler.Mappers;
using CoffeeMaker.Hardware.Interface;

using CoreBoilerStatus = CoffeeMaker.Core.Enums.BoilerStatus;

namespace CoffeeMaker.Hardware.Adapter.Boiler.Queries;

public class BoilerStatusQuery :
    IQuery<CoreBoilerStatus>
{
    private readonly ICoffeeMakerApi api;

    public BoilerStatusQuery(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public CoreBoilerStatus Execute()
    {
        return api.GetBoilerStatus().Map();
    }
}
