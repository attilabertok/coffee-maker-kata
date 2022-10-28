using CoffeeMaker.Api.Queries;
using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.Boiler.Queries;
using CoffeeMaker.Hardware.Interface;

using BoilerStatus = CoffeeMaker.Core.Enums.BoilerStatus;

namespace CoffeeMaker.Hardware.Adapter.Boiler;

public class BoilerQueries : IBoilerQueries
{
    public BoilerQueries(ICoffeeMakerApi api)
    {
        Status = new BoilerStatusQuery(api);
    }

    public IQuery<BoilerStatus> Status { get; }
}
