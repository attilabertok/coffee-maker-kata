using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.Boilers.Queries;
using CoffeeMaker.Hardware.Interface;

using BoilerStatus = CoffeeMaker.Core.Enums.BoilerStatus;

namespace CoffeeMaker.Hardware.Adapter.Boilers;

public class BoilerQueries : IBoilerQueries
{
    public BoilerQueries(ICoffeeMakerApi api)
    {
        Status = new BoilerStatusQuery(api);
    }

    public IQuery<BoilerStatus> Status { get; }
}
