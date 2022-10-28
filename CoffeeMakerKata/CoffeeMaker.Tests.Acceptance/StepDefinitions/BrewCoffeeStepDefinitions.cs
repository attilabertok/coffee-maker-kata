using CoffeeMaker.Core.Enums;
using CoffeeMaker.Hardware.Adapter;
using CoffeeMaker.Hardware.Interface;
using CoffeeMaker.Services;
using CoffeeMaker.Tests.Acceptance.Support.Factories;
using BoilerStatus = CoffeeMaker.Hardware.Interface.BoilerStatus;
using BrewButtonStatus = CoffeeMaker.Hardware.Interface.BrewButtonStatus;
using WarmerPlateStatus = CoffeeMaker.Hardware.Interface.WarmerPlateStatus;

namespace CoffeeMaker.Tests.Acceptance.StepDefinitions
{
    [Binding]
    public class BrewCoffeeStepDefinitions
    {
        private ICoffeeMakerApi? coffeeMakerApi;

        private ICoffeeMaker? coffeeMaker;
        private CoffeeMakerState state;

        [Given(@"a coffee maker in (.*) state")]
        public void GivenACoffeeMakerInACertainState(CoffeeMakerState state)
        {
            this.state = state;

            coffeeMakerApi = Substitute.For<ICoffeeMakerApi>();
        }

        [Given(@"an empty pot placed on the warmer plate")]
        public void GivenAnEmptyPotPlacedOnTheWarmerPlate()
        {
            coffeeMakerApi.GetWarmerPlateStatus().Returns(WarmerPlateStatus.PotEmpty);
        }

        [Given(@"a not empty pot placed on the warmer plate")]
        public void GivenANotEmptyPotPlacedOnTheWarmerPlate()
        {
            coffeeMakerApi.GetWarmerPlateStatus().Returns(WarmerPlateStatus.PotNotEmpty);
        }

        [Given(@"no pot is placed on the warmer plate")]
        public void GivenNoPotIsPlacedOnTheWarmerPlate()
        {
            coffeeMakerApi.GetWarmerPlateStatus().Returns(WarmerPlateStatus.WarmerEmpty);
        }

        [Given(@"a boiler filled with water")]
        public void GivenABoilerFilledWithWater()
        {
            coffeeMakerApi.GetBoilerStatus().Returns(BoilerStatus.NotEmpty);
        }

        [Given(@"an empty boiler")]
        public void GivenAnEmptyBoiler()
        {
            coffeeMakerApi.GetBoilerStatus().Returns(BoilerStatus.Empty);
        }

        [When(@"the coffee brewing is started")]
        public void WhenTheCoffeeBrewingIsStarted()
        {
            coffeeMakerApi.GetBrewButtonStatus().Returns(BrewButtonStatus.Pushed);

            var commands = new CoffeeMakerCommandInterface(coffeeMakerApi);
            var systemStatusProvider = new SystemStatusProvider(new CoffeeMakerQueryInterface(coffeeMakerApi));
            coffeeMaker = CoffeeMakerFactory.CreateMark4(state, commands, systemStatusProvider);

            coffeeMaker!.Start();
        }

        [Then(@"a pot of coffee is brewed")]
        public void ThenAPotOfCoffeeIsBrewed()
        {
            coffeeMaker!.State.Should()
                .Be(CoffeeMakerState.Brewing);
        }

        [Then(@"(.*) error is reported")]
        public void ThenAnErrorIsReported(string errorType)
        {
            coffeeMaker!.State.Should()
                .Be(CoffeeMakerState.Error);
        }
    }
}
