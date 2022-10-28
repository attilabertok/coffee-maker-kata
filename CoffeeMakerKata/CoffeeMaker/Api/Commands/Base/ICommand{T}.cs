﻿namespace CoffeeMaker.Api.Commands.Base;

public interface ICommand<in T>
{
    public void Execute(T parameter);
}
