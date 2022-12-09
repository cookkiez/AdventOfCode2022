namespace Day2
{
    public class Solution
    {
        public int Solve(string[] lines)
        {
            var selectedScores = new Dictionary<String, int>()
                { {"A",  1},  {"B",  2}, {"C",  3} };
            var winMap = new Dictionary<String, String>()
                { {"A", "B"}, {"B", "C"}, {"C", "A"} };
            var loseMap = new Dictionary<String, String>()
                { {"A", "C"}, {"B", "A"}, {"C", "B"} };
            var scoreSum = 0;
            foreach (var line in lines)
            {
                var split = line.Split(" ");
                var opponent = split[0];
                var you = split[1];
                var currScore = 0;
                if (you.Equals("Y")) { currScore += 3 + selectedScores[opponent];  }
                else if (you.Equals("X"))
                {
                    currScore += selectedScores[loseMap[opponent]];
                } else
                {
                    currScore += selectedScores[winMap[opponent]];
                    currScore += 6;
                }
                scoreSum += currScore;
            }

            return scoreSum;
        }
    }
}