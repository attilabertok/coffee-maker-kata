namespace CoffeeMaker.Tests.Acceptance.Support.Extensions;

public static class CoffeeMakerStateProviderExtensions
{
    public static void SetState(this ICoffeeMakerStateProvider stateProvider, CoffeeMakerState state)
    {
        stateProvider.State.Returns(state);
    }
}
