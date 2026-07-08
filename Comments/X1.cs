namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int sum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            // Add square of each number in the range
            sum += Square(i);
        }

        return sum;
    }

    static int Square(int k)
    {
        // Return square of input
        return k * k;
    }
}