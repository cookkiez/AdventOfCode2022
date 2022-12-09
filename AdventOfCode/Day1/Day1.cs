namespace Day1
{
    public class Solution
    {
        public int Solve(string[] lines)
        {
            var currSum = 0;
            var maxSum = 0;
            var sums = new List<int>();
            foreach (string line in lines)
            {
                if(line.Equals("\n") || line.Equals(""))
                {
                    maxSum = (currSum > maxSum) ? currSum : maxSum;
                    sums.Add(currSum);
                    currSum = 0;
                } else { currSum += int.Parse(line); }

            }
            sums = sums.OrderByDescending(x => x).ToList();
            return sums[0] + sums[1] + sums[2];
        }
    }
}