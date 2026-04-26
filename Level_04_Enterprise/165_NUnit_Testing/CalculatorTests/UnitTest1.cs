using NUnit.Framework;

public class Tests
{
    [Test]
    public void Add_ReturnsCorrectSum()
    {
        var calc = new Calculator();

        int result = calc.Add(2, 3);

        Assert.AreEqual(5, result);
    }
}