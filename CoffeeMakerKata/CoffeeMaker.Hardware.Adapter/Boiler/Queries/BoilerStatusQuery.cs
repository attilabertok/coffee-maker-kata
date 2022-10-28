using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Boiler.Queries;

public class BoilerStatusQuery :
    IQuery<BoilerStatus>
{
    private readonly ICoffeeMakerApi api;

    public BoilerStatusQuery(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public BoilerStatus Execute()
    {
        return api.GetBoilerStatus();
    }
}
