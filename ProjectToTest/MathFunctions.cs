
namespace ProjectToTest
{
    public class MathFunctions
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Max(int x, int y)
        {
            if (x > y) return x;
            if (y > x) return y;
            return int.MaxValue;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for(int i = 0; i <= limit; ++i)
            {
                if(i % 2 == 1)
                {
                    yield return i;
                }
            }
        }
    }
}
