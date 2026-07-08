namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class X1Test
{
    [Test]
    public void T1()
    {
        int lowerBound = 7;
        int upperBound = 12;

        int expected = 0;
        for (int i = lowerBound; i <= upperBound; i++)
        {
            expected += i * i;
        }

        int actual = Maths.SumOfSquares(lowerBound, upperBound);

        Assert.That(actual, Is.EqualTo(expected));
    }
}