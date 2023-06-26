namespace Tools.Tests;

public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddReturns4WhenGiven2And2()
    {
        Calculator calculator = new Calculator();
        int result = calculator.add(2, 2);
        Assert.AreEqual(4, result);
    }
    
    [Test]
    [TestCase(10,10)]
    [TestCase(21,7)]
    public void TestSubtractReturns2WhenGiven4and2(int minuend, int subtrahend)
    {
        Calculator calculator = new Calculator();
        int result = calculator.subtract(minuend, subtrahend);
        int expectedResult = minuend - subtrahend;
        Assert.AreEqual(expectedResult, result);
    }
}
