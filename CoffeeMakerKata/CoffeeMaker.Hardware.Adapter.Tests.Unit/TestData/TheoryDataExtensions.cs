using EnumsNET;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.TestData;

public static class TheoryDataExtensions
{
    public static void AddEnumValues<T>(this TheoryData<T> instance)
        where T : struct, Enum
    {
        var values = Enums.GetMembers<T>();

        foreach (var value in values)
        {
            instance.Add(value.Value);
        }
    }
}
