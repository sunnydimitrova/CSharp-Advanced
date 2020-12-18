using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestAndPassword = new Dictionary<string, string>();
            var studentsInfo = new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                var splitedIput = input.Split(":");
                var contest = splitedIput[0];
                var password = splitedIput[1];
                contestAndPassword.Add(contest, password);
            }
            string secondInput;
            while ((secondInput = Console.ReadLine()) != "end of submissions")
            {
                var splitedSecondInput = secondInput.Split("=>");
                var contest = splitedSecondInput[0];
                var password = splitedSecondInput[1];
                var name = splitedSecondInput[2];
                var points = int.Parse(splitedSecondInput[3]);
                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == password)
                {
                    if (!studentsInfo.ContainsKey(name))
                    {
                        studentsInfo.Add(name, new Dictionary<string, int>());
                    }                    
                    if (!studentsInfo[name].ContainsKey(contest))
                    {
                        studentsInfo[name].Add(contest, 0);
                    }
                    if (studentsInfo[name][contest] < points)
                    {
                        studentsInfo[name][contest] = points;
                    }
                }
            }
            var orderCandidates = studentsInfo.OrderBy(x => x.Key).ThenByDescending(x => x.Value.Values);
            var bestPoints = 0;
            var bestStudent = "";
            foreach (var item in orderCandidates)
            {
                if (item.Value.Values.Sum() > bestPoints)
                {
                    bestPoints = item.Value.Values.Sum();
                    bestStudent = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var candidat in orderCandidates)
            {
                Console.WriteLine(candidat.Key);
                foreach (var contest in candidat.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
