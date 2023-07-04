namespace TestDojo.Fundamentals;

public class Numbers
{
    public int Add(int a, int b) => a + b;

    public async Task<int> AddAsync(int x, int y)
    {
        await Task.Delay(100); 
        return 42;
    }

    public int Max(int a, int b) => (a > b) ? a : b;

    public double Divide(double numerator, double denominator)
    {
        if (denominator == 0) throw new InvalidOperationException("denominator can't be zero!");
        return numerator / denominator;
    }

    public IEnumerable<int> GetEvenNumbers(int limit)
    {
        if (limit <= 0) throw new ArgumentOutOfRangeException(nameof(limit));

        for (var i = 1; i <= limit; i++)
            if (i % 2 == 0)
                yield return i;
    }
}

