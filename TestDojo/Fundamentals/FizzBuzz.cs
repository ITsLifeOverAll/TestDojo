namespace TestDojo.Fundamentals
{
    public class FizzBuzz
    {
        // https://leetcode.com/problems/fizz-buzz/

        public IList<string> GetFizzBuzz(int n)
        {
            // notice there's a bug below - can you spot it?

            if (n <= 0) throw new ArgumentOutOfRangeException("parameter n should be large than 0");

            var list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) list.Add("FizzBuzz");
                else if (i % 3 == 0) list.Add("Fizz");
                else if (i % 5 == 0) list.Add("Buzz");
                list.Add(i.ToString()); 
            }
            return list;
        }
    }
}
