﻿using CoffeeMaker.Core.Api.Commands;
using CoffeeMaker.Core.Api.Commands.Base;
using CoffeeMaker.Hardware.Adapter.Indicators.Commands;
using CoffeeMaker.Hardware.Interface;

namespace CoffeeMaker.Hardware.Adapter.Indicators;

public class IndicatorCommands : IIndicatorCommands
{
    public IndicatorCommands(ICoffeeMakerApi api)
    {
        SignalError = new SignalErrorCommand(api);
        TurnOn = new TurnOnIndicatorCommand(api);
        TurnOff = new TurnOffIndicatorCommand(api);
    }

    public IAsyncCommand SignalError { get; }

    public ICommand TurnOn { get; }

    public ICommand TurnOff { get; }
}
