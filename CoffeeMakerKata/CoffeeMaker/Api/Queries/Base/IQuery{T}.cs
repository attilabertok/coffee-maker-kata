namespace CoffeeMaker.Api.Queries.Base;

public interface IQuery<out T>
{
    T Execute();
}
