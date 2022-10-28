using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Api.Queries;

public interface IWarmerPlateQueries
{
    IQuery<WarmerPlateStatus> Status { get; }
}
