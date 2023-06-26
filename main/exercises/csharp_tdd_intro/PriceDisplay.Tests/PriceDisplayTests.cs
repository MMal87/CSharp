namespace PriceDisplay.Tests
{
  public class PriceDisplayTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    [TestCase("Apple", 0.20)]
    [TestCase("Banana", 0.30)]
    
    public void Get_Label_for_fruit(string item, double price)
    {
      PriceDisplay priceDisplay = new PriceDisplay();
      string actual = priceDisplay.GetPriceLabel(item, price);
      string expected = $"The price for item: {item} is {price}";
      Assert.AreEqual(actual, expected);
    }
  }
}