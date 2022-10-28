using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Interface;

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
        return api.GetBrewButtonStatus();
    }
}
