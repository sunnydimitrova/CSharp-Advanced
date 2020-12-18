using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ");
                var color = input[0];
                var clothes = input[1].Split(",");
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                    
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    var currentClothes = clothes[j];
                    if (!dict[color].ContainsKey(currentClothes))
                    {
                        dict[color].Add(currentClothes, 0);
                    }
                    dict[color][currentClothes]++;
                }
            }
            var foundClothes = Console.ReadLine().Split();
            var findColor = foundClothes[0];
            var findClothes = foundClothes[1];   
            foreach (var color in dict)
            {
                var currentColor = color.Key.ToString();
                Console.WriteLine($"{color.Key} clothes:");
                    foreach (var clothes in dict[color.Key])
                    {
                    var currentClothes = clothes.Key.ToString(); 
                        if (currentColor == findColor && currentClothes == findClothes)
                        {
                            Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                        }
                    }
            }
        }
    }
}
