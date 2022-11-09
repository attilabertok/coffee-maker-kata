using CoffeeMaker.Core.Entities.Boilers;
using CoffeeMaker.Core.Entities.BrewButtons;
using CoffeeMaker.Core.Entities.WarmerPlates;
using CoffeeMaker.Core.Enums;
using CoffeeMaker.Services;
using CoffeeMaker.Tests.Acceptance.Support.Factories;

using BoilerStatus = CoffeeMaker.Core.Enums.BoilerStatus;
using BrewButtonStatus = CoffeeMaker.Core.Enums.BrewButtonStatus;
using WarmerPlateStatus = CoffeeMaker.Core.Enums.WarmerPlateStatus;

namespace CoffeeMaker.Tests.Acceptance.StepDefinitions
{
    [Binding]
    public class BrewCoffeeStepDefinitions
    {
        private readonly IBoiler boiler = Substitute.For<IBoiler>();
        private readonly IBrewButton brewButton = Substitute.For<IBrewButton>();
        private readonly IWarmerPlate warmerPlate = Substitute.For<IWarmerPlate>();

        private ICoffeeMaker? coffeeMaker;
        private CoffeeMakerState state;

        [Given(@"a coffee maker in (.*) state")]
        public void GivenACoffeeMakerInACertainState(CoffeeMakerState coffeeMakerState)
        {
            state = coffeeMakerState;
        }

        [Given(@"an empty pot placed on the warmer plate")]
        public void GivenAnEmptyPotPlacedOnTheWarmerPlate()
        {
            warmerPlate.Status.Returns(WarmerPlateStatus.PotEmpty);
        }

        [Given(@"a not empty pot placed on the warmer plate")]
        public void GivenANotEmptyPotPlacedOnTheWarmerPlate()
        {
            warmerPlate.Status.Returns(WarmerPlateStatus.PotNotEmpty);
        }

        [Given(@"no pot is placed on the warmer plate")]
        public void GivenNoPotIsPlacedOnTheWarmerPlate()
        {
            warmerPlate.Status.Returns(WarmerPlateStatus.WarmerEmpty);
        }

        [Given(@"a boiler filled with water")]
        public void GivenABoilerFilledWithWater()
        {
            boiler.Status.Returns(BoilerStatus.NotEmpty);
        }

        [Given(@"an empty boiler")]
        public void GivenAnEmptyBoiler()
        {
            boiler.Status.Returns(BoilerStatus.Empty);
        }

        [When(@"the coffee brewing is started")]
        public void WhenTheCoffeeBrewingIsStarted()
        {
            brewButton.Status.Returns(BrewButtonStatus.Pushed);

            var systemStatusProvider = new SystemStatusProvider(boiler, brewButton, warmerPlate);
            coffeeMaker = CoffeeMakerFactory.CreateMark4(state, systemStatusProvider);

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
