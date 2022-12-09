using System.Collections.Generic;
using System.Globalization;

namespace Day5
{
    public class Solution
    {
        public string Solve(string[] lines)
        {
            var numOfStacks = lines[0].Split(" ").Length / 3;
            var i = 0;
            var stacks = new List<List<char>>();
            for (var n = 0;n < numOfStacks; n++) { stacks.Add(new List<char>()); }
            var currLine = lines[i];
            while (currLine[1] - '0' != 1)
            {
                for (var j = 1; j < currLine.Length; j++)
                {
                    if (Char.IsLetter(currLine[j]))
                    {
                        var currChar = currLine[j];
                        //Console.WriteLine($"{(int)((j - (j / 4)) / 3)}, {currChar}");
                        stacks[(int)((j - (j / 4)) / 3)].Insert(0, currChar);
                    }
                }
                i++;
                currLine = lines[i];
            }
            i += 2;
            var newStacks = stacks.Select(s => new Stack<char>(s)).ToList();
            while (i < lines.Length)
            {
                var splitted = lines[i].Split(" ").ToList();
                var num = int.Parse(splitted[1]);
                var src = int.Parse(splitted[3]) - 1;
                var dst = int.Parse(splitted[5]) - 1;
                var tempStack = new Stack<char>();
                while (num-- > 0)
                {
                    var c = newStacks[src].Pop();
                    tempStack.Push(c);
                }
                while(tempStack.Count > 0)
                {
                    newStacks[dst].Push(tempStack.Pop());
                }
                i++;
            }

            var str = "";
            foreach(var s in newStacks)
            {
                str += s.Pop();
            }
            return str;
        }
    }
}