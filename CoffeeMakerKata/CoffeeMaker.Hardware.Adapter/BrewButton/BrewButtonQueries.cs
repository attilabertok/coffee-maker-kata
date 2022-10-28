using CoffeeMaker.Api.Queries;
using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.BrewButton.Queries;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.BrewButton;

public class BrewButtonQueries : IBrewButtonQueries
{
    public BrewButtonQueries(ICoffeeMakerApi api)
    {
        Status = new BrewButtonStatusQuery(api);
    }

    public IQuery<BrewButtonStatus> Status { get; }
}
