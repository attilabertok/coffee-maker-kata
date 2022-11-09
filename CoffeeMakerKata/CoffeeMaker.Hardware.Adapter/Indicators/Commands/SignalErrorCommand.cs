using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Indicators.Commands;

public class SignalErrorCommand : IAsyncCommand
{
    private const int FlashCount = 3;

    private static readonly TimeSpan OnInterval = TimeSpan.FromMilliseconds(100);
    private static readonly TimeSpan OffInterval = TimeSpan.FromMilliseconds(100);

    private readonly ICoffeeMakerApi api;

    public SignalErrorCommand(ICoffeeMakerApi api)
    {
        this.api = api;
    }

    public async Task ExecuteAsync()
    {
        for (var i = 0; i < FlashCount; i++)
        {
            api.SetIndicatorState(IndicatorState.On);
            await Task.Delay(OnInterval);
            api.SetIndicatorState(IndicatorState.Off);
            await Task.Delay(OffInterval);
        }
    }
}
