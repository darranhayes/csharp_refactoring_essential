namespace Comments;

public class Maths
{
    public static int SumOfSquaresForARange(int lowerBound, int upperBound)
    {
        int sum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            sum += Square(i);
        }

        return sum;
    }

    private static int Square(int n)
    {
        return n * n;
    }
}