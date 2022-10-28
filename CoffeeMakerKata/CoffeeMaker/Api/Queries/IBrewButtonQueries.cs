using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Api.Queries;

public interface IBrewButtonQueries
{
    IQuery<BrewButtonStatus> Status { get; }
}
