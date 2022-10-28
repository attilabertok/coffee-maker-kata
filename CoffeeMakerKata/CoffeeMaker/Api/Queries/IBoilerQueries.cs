using CoffeeMaker.Api.Queries.Base;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Api.Queries;

public interface IBoilerQueries
{
    IQuery<BoilerStatus> Status { get; }
}
