using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Api.Queries;

public interface IWarmerPlateQueries
{
    IQuery<WarmerPlateStatus> Status { get; }
}
