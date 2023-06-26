namespace Calculator.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Adds_as_expected()
    {   
        CSharp.Intro.Calculator calculator = new CSharp.Intro.Calculator();
        int result = calculator.Calculate(2,3)
        Assert.AreEqual(5, result);
    }
}