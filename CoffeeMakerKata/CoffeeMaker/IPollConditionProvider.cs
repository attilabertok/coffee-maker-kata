namespace CoffeeMaker;

public interface IPollConditionProvider
{
    Func<bool> PollCondition { get; }
}
