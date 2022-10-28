using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.BrewButton.Mappers;
using CoffeeMaker.Hardware.Interface;

using BrewButtonStatus = CoffeeMaker.Core.Enums.BrewButtonStatus;

namespace CoffeeMaker.Hardware.Adapter.BrewButton.Queries;

public class BrewButtonStatusQuery :
    IQuery<BrewButtonStatus>
{
    private readonly ICoffeeMakerApi api;

    public BrewButtonStatusQuery(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public BrewButtonStatus Execute()
    {
        return api.GetBrewButtonStatus().Map();
    }
}
