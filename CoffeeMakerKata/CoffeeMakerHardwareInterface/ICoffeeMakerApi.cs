namespace CoffeeMakerHardwareInterface;

public interface ICoffeeMakerApi
{
    /// <summary>
    /// This sensor detects the presence of the pot and whether it has coffee in it.
    /// </summary>
    /// <returns>The status of the warmer-plate sensor.</returns>
    public WarmerPlateStatus GetWarmerPlateStatus();

    /// <summary>
    /// The boiler switch is a float switch that detects if there is more than 1/2 cup of water in the boiler.
    /// </summary>
    /// <returns>The status of the boiler switch.</returns>
    public BoilerStatus GetBoilerStatus();

    /// <summary>
    /// The brew button is a momentary switch that remembers its state. Each call to this function returns the
    /// remembered state and then resets that state to NOT_PUSHED.
    /// Thus, even if this function is polled at a very slow rate, it will still detect when the brew button is
    /// pushed.
    /// </summary>
    /// <returns>The status of the brew button.</returns>
    public BrewButtonStatus GetBrewButtonStatus();

    /// <summary>
    /// This function turns the heating element in the boiler on or off.
    /// </summary>
    /// <param name="s">The new boiler state.</param>
    public void SetBoilerState(BoilerState s);

    /// <summary>
    /// This function turns the heating element in the warmer plate on or off.
    /// </summary>
    /// <param name="s">The new warmer state.</param>
    public void SetWarmerState(WarmerState s);

    /// <summary>
    /// This function turns the indicator light on or off.
    /// </summary>
    /// <remarks>
    /// The indicator light should be turned on at the end of the brewing cycle.
    /// It should be turned off when the user presses the brew button.
    /// </remarks>
    /// <param name="s">The new indicator state.</param>
    public void SetIndicatorState(IndicatorState s);

    /// <summary>
    /// This function opens and closes the pressure-relief valve.
    /// When this valve is closed, steam pressure in the boiler will force hot water to spray out over the coffee filter.
    /// When the valve is open, the steam in the boiler escapes into the environment, and the water in the boiler will not spray out over the filter.
    /// </summary>
    /// <param name="s">The new relief valve state.</param>
    public void SetReliefValveState(ReliefValveState s);
}
