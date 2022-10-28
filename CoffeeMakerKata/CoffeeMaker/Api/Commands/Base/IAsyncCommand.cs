namespace CoffeeMaker.Api.Commands.Base;

public interface IAsyncCommand
{
    Task ExecuteAsync();
}
