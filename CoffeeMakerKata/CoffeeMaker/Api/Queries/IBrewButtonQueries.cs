using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Api.Queries;

public interface IBrewButtonQueries
{
    IQuery<BrewButtonStatus> Status { get; }
}
