# coffee-maker-kata
c# implementation of Uncle Bob's Mark IV Coffee Maker kata

## Specification

The Mark IV Special makes up to 12 cups of coffee at a time. The user places a filter in the filter holder, fills the filter with coffee grounds, and slides the filter holder into its receptacle. The user then pours up to 12 cups of water into the water strainer and presses the Brew button. The water is heated until boiling. The pressure of the evolving steam forces the water to be sprayed over the coffee grounds, and coffee drips through the filter into the pot. The pot is kept warm for extended periods by a warmer plate, which turns on only if coffee is in the pot. If the pot is removed from the warmer plate while water is being sprayed over the grounds, the flow of water is stopped so that brewed coffee does not spill on the warmer plate. The following hardware needs to be monitored or controlled:
* The heating element for the boiler. It can be turned on or off.
* The heating element for the warmer plate. It can be turned on or off.
* The sensor for the warmer plate. It has three states: warmerEmpty, potEmpty, potNotEmpty.
* A sensor for the boiler, which determines whether water is present. It has two states: boilerEmpty or boilerNotEmpty.
* The Brew button. This momentary button starts the brewing cycle. It has an indicator that lights up when the brewing cycle is over and the coffee is ready.
* A pressure-relief valve that opens to reduce the pressure in the boiler. The drop in pressure stops the flow of water to the filter. The value can be opened or closed.

The hardware for the Mark IV has been designed and is currently under development. The hardware engineers have even provided a low-level API for us to use, so we don't have to write any bit- twiddling I/O driver code.

    namespace CoffeeMaker
    {
        public enum WarmerPlateStatus
        {
            WARMER_EMPTY,
            POT_EMPTY,
            POT_NOT_EMPTY
        };

        public enum BoilerStatus
        {
            EMPTY,
            NOT_EMPTY
        };

        public enum BrewButtonStatus
        {
            PUSHED,
            NOT_PUSHED
        };

        public enum BoilerState
        {
            ON,
            OFF
        };

        public enum WarmerState
        {
            ON,
            OFF
        };

        public enum IndicatorState
        {
            ON,
            OFF
        };

        public enum ReliefValveState
        {
            OPEN,
            CLOSED
        };

        public interface CoffeeMakerAPI
        {
           /*
            * This function returns the status of the warmer-plate
            * sensor. This sensor detects the presence of the pot
            * and whether it has coffee in it.
            */
            WarmerPlateStatus GetWarmerPlateStatus();

           /*
            * This function returns the status of the boiler switch.
            * The boiler switch is a float switch that detects if
            * there is more than 1/2 cup of water in the boiler.
            */
            BoilerStatus GetBoilerStatus();

           /*
            * This function returns the status of the brew button.
            * The brew button is a momentary switch that remembers
            * its state. Each call to this function returns the
            * remembered state and then resets that state to
            * NOT_PUSHED.
            *
            * Thus, even if this function is polled at a very slow
            * rate, it will still detect when the brew button is
            * pushed.
            */
            BrewButtonStatus GetBrewButtonStatus();

           /*
            * This function turns the heating element in the boiler
            * on or off.
            */
            void SetBoilerState(BoilerState s);

           /*
            * This function turns the heating element in the warmer
            * plate on or off.
            */
            void SetWarmerState(WarmerState s);

           /*
            * This function turns the indicator light on or off.
            * The indicator light should be turned on at the end
            * of the brewing cycle. It should be turned off when
            * the user presses the brew button.
            */
            void SetIndicatorState(IndicatorState s);

           /*
            * This function opens and closes the pressure-relief
            * valve. When this valve is closed, steam pressure in
            * the boiler will force hot water to spray out over
            * the coffee filter. When the valve is open, the steam
            * in the boiler escapes into the environment, and the
            * water in the boiler will not spray out over the filter.
            */
            void SetReliefValveState(ReliefValveState s);
        }
    }
