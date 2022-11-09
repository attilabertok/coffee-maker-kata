using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.BrewButtons.Queries;
using CoffeeMaker.Hardware.Interface;

using BrewButtonStatus = CoffeeMaker.Core.Enums.BrewButtonStatus;

namespace CoffeeMaker.Hardware.Adapter.BrewButtons;

public class BrewButtonQueries : IBrewButtonQueries
{
    public BrewButtonQueries(ICoffeeMakerApi api)
    {
        Status = new BrewButtonStatusQuery(api);
    }

    public IQuery<BrewButtonStatus> Status { get; }
}
