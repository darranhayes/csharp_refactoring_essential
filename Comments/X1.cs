namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int sum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            sum += Square(i);
        }

        return sum;
    }

    static int Square(int n)
    {
        // Return square of input
        return n * n;
    }
}