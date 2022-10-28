using CoffeeMaker.Api.Queries;
using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Queries;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlate;

public class WarmerPlateQueries : IWarmerPlateQueries
{
    public WarmerPlateQueries(ICoffeeMakerApi api)
    {
        Status = new WarmerPlateStatusQuery(api);
    }

    public IQuery<WarmerPlateStatus> Status { get; }
}
