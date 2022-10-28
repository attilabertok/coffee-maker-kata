namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.TestData;

public class EnumTheoryData<T> :
    TheoryData<T>
    where T : struct, Enum
{
    public EnumTheoryData()
    {
        this.AddEnumValues();
    }
}
