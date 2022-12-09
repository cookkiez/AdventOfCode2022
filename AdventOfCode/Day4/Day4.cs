using System.Text;

namespace Day4
{
    public class Solution
    {
        public int Solve(string[] lines)
        {
            var cnt = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                var splitLine = lines[i].Split(",");
                var first = splitLine[0].Split("-").Select(x => int.Parse(x)).ToList();
                var second = splitLine[1].Split("-").Select(x => int.Parse(x)).ToList();

                if (CompareVals(first[0], first[1], second[0], second[1]) ||
                   CompareVals(second[0], second[1], first[0], first[1])) 
                    { cnt++; }
            }
            return cnt;
        }

        private bool CompareVals(int firstLow, int firstHigh, int secondLow, int secondHigh)
        {
            return ((firstLow >= secondLow) && (firstHigh <= secondHigh)) ||
                (firstHigh == secondLow) || (firstLow == secondHigh) ||
                ((firstLow <= secondLow) && (firstHigh <= secondHigh) && (firstHigh >= secondLow));
        }
    }
}