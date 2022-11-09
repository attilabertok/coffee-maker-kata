using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlates.Queries;
using CoffeeMaker.Hardware.Interface;

using WarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlates;

public class WarmerPlateQueries : IWarmerPlateQueries
{
    public WarmerPlateQueries(ICoffeeMakerApi api)
    {
        Status = new WarmerPlateStatusQuery(api);
    }

    public IQuery<WarmerPlateStatus> Status { get; }
}
