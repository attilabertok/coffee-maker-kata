using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Api.Queries;

public interface IBoilerQueries
{
    IQuery<BoilerStatus> Status { get; }
}
