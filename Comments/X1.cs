namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int p = 0;

        // Iterate from lower bound (q) to upper bound (z)
        for (int i = lowerBound; i <= upperBound; i++)
        {
            // Add square of each number in the range
            p += N(i);
        }

        // Return accumulated sum
        return p;
    }

    static int N(int k)
    {
        // Return square of input
        return k * k;
    }
}