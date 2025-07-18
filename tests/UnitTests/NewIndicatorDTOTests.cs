namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateValueFromFood()
    {
        // Arrange
        IndicatorForm indicatorForm = new IndicatorForm()
        {
            IndicatorId = 1,
            FactValue = (decimal)10.5,
            Indicator = new Indicator
            {
                Id = 1,
                Name = "test",
                MinStandart = 30,
                MaxStandart = 50
            }
        };
        
        // Act
        NewIndicatorDTO newIndicatorDTO = NewIndicatorDTO.Create(indicatorForm, (decimal)10.5);
        
        // Assert
        Assert.AreEqual(newIndicatorDTO.FromFood, (decimal)9);
    }
}
