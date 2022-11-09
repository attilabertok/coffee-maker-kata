namespace CoffeeMaker.Core.Api.Queries.Base;

public interface IQuery<out T>
{
    T Execute();
}
