using Bogus;
using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Services.Data;

namespace CoffeeMaker.Tests.Support.Factories;

public class SystemStatusGenerator
{
    private readonly Faker faker;

    public SystemStatusGenerator()
    {
        faker = new Faker();
    }

    public SystemStatus GenerateStatus()
    {
        var brewButtonStatus = faker.PickRandom<BrewButtonStatus>();
        var warmerPlateStatus = faker.PickRandom<WarmerPlateStatus>();
        var boilerStatus = faker.PickRandom<BoilerStatus>();

        return new SystemStatus(brewButtonStatus, warmerPlateStatus, boilerStatus);
    }
}
