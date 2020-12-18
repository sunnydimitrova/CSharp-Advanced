using System;
using System.IO;
using System.Linq;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = File.ReadAllLines("./text.txt");
            for (int i = 0; i < reader.Length; i++)
            {
                var currentLine = reader[i];
                var sumOfLetter = CountLetter(currentLine);
                var sumOfMarks = CountMarks(currentLine);
                reader[i] = $"Line {i + 1}: {currentLine} ({sumOfLetter})({sumOfMarks})";
            }
            File.WriteAllLines("../../../output.txt", reader);
        }
        static int CountLetter(string line)
        {
            var counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentLetter = line[i];
                if (char.IsLetter(currentLetter))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountMarks(string line)
        {
            var counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                var currentSymbol = line[i];
                if (char.IsPunctuation(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
