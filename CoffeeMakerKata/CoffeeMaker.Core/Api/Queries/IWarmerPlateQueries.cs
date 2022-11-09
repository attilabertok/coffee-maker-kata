using CoffeeMaker.Core.Api.Queries.Base;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Api.Queries;

public interface IWarmerPlateQueries
{
    IQuery<WarmerPlateStatus> Status { get; }
}
