namespace CoffeeMaker.Core.Api.Commands.Base;

public interface IAsyncCommand
{
    Task ExecuteAsync();
}
