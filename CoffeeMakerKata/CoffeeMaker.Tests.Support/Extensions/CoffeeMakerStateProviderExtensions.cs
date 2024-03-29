﻿using CoffeeMaker.Core;
using CoffeeMaker.Core.Enums;
using NSubstitute;

namespace CoffeeMaker.Tests.Support.Extensions;

public static class CoffeeMakerStateProviderExtensions
{
    public static void SetState(this ICoffeeMakerStateProvider stateProvider, CoffeeMakerState state)
    {
        stateProvider.State.Returns(state);
    }
}
