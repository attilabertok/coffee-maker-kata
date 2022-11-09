using CoffeeMaker.Core.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.BrewButtons.Mappers;
using CoffeeMaker.Hardware.Interface;

using BrewButtonStatus = CoffeeMaker.Core.Enums.BrewButtonStatus;

namespace CoffeeMaker.Hardware.Adapter.BrewButtons.Queries;

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
