using System.Text;

namespace Day3
{
    public class Solution
    {
        public int Solve(string[] lines)
        {
            var sumPrio = 0;
            for(int i = 0; i < lines.Length; i += 3)
            {
                var first = Encoding.ASCII.GetBytes(lines[i]);
                var second = Encoding.ASCII.GetBytes(lines[i + 1]);
                var third = Encoding.ASCII.GetBytes(lines[i + 2]);
                foreach (var c in first)
                {
                    if (second.Contains(c) && third.Contains(c))
                    {
                        sumPrio += 1 + c - ((c < 97) ? 65 - 26 : 97);
                        break;
                    }
                }
                
            }
            return sumPrio;
        }
    }
}