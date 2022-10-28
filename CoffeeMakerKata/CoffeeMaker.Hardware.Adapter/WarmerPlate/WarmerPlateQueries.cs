using CoffeeMaker.Api.Queries;
using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Mappers;
using CoffeeMaker.Hardware.Adapter.WarmerPlate.Queries;
using CoffeeMaker.Hardware.Interface;

using WarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;

namespace CoffeeMaker.Hardware.Adapter.WarmerPlate;

public class WarmerPlateQueries : IWarmerPlateQueries
{
    public WarmerPlateQueries(ICoffeeMakerApi api)
    {
        Status = new WarmerPlateStatusQuery(api);
    }

    public IQuery<WarmerPlateStatus> Status { get; }
}
