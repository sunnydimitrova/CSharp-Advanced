using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                var splitedInput = input.Split();
                var name = splitedInput[0];
                var command = splitedInput[1];
                var followedVloger = splitedInput[2];
                if (command == "joined")
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new Dictionary<string, List<string>>() {
                            { "followers", new List<string>() }, {"following", new List<string>()}
                        });
                    }
                }
                else if (command == "followed")
                {
                    if (dict.ContainsKey(name) && dict.ContainsKey(followedVloger))
                    {
                        if (dict[name] != dict[followedVloger] && !dict[name]["following"].Contains(followedVloger))
                        {
                            dict[name]["following"].Add(followedVloger);
                            dict[followedVloger]["followers"].Add(name);
                        }
                        
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");
            var orderDict = dict.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count);
            var counter = 1;
            foreach (var item in orderDict)
            {               
                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var followers in item.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }
                counter++;
            }
               
        }
    }
}
